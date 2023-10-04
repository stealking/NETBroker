﻿using AutoMapper;
using Core.ActionFilters;
using Core.Entities;
using Core.Entities.Enums;
using Core.Extensions;
using Core.Models.Requests.Users;
using Core.Models.Response.Users;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("api/users")]
    public class UserController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        private readonly IMapper mapper;
        private readonly ILoggerManager logger;
        public UserController(IServiceManager serviceManager, IMapper mapper, ILoggerManager logger)
        {
            this.serviceManager = serviceManager;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var user = await serviceManager.UserService.GetAll();
            return CreateSuccessResult(user);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await serviceManager.UserService.GetById(id);
            if (user == null)
            {
                return CreateFailResult("User not found.");
            }

            return CreateSuccessResult(user);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            var user = await serviceManager.UserService.Autheticate(request);
            if (user == null)
            {
                return CreateFailResult("UserName or password is incorrect.");
            }

            var token = serviceManager.AuthenticationService.CreateToken(user);

            return CreateSuccessResult( new
            {
                token,
                user = mapper.Map<UserResponse>(user)
            });
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return CreateModelStateErrors(ModelState);
            }

            var user = await serviceManager.UserService.GetByUserName(request.UserName);
            if (user != null)
            {
                return CreateFailResult("The UserName has already existed");
            }

            user = mapper.Map<UserProfile>(request);
            user.PasswordHash = StringExtensions.HashPassword(request.Password);
            await serviceManager.UserService.Create(user);
            return CreateSuccessResult(mapper.Map<UserResponse>(user));
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return CreateModelStateErrors(ModelState);
            }

            var user = await serviceManager.UserService.GetById(request.Id ?? 0);
            if (user == null)
            {
                return CreateFailResult("User not found.");
            }

            mapper.Map(request, user);
            await serviceManager.UserService.Update(user);
            return CreateSuccessResult(mapper.Map<UserResponse>(user));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await serviceManager.UserService.GetById(id);
            if (user == null)
            {
                return CreateFailResult("User not found.");
            }

            await serviceManager.UserService.Delete(id);
            return CreateSuccess();
        }
    }
}
