using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities;
using Core.Entities.Enums;
using Core.Extensions;
using Core.Models.Requests;
using Core.Models.Requests.Contracts;
using Core.Models.Response.Contracts;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Domain.Services
{
    public class ContractService : IContractService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ContractService(IRepositoryManager repositoryManager, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<bool> Create(IRequest baseRequest)
        {
            var request = (ContractRequest)baseRequest;
            var contact = await repositoryManager.Contact.FindById(request.ContactId ?? 0);
            if (contact == null)
            {
                throw new ArgumentException("Contact is not found!");
            }

            if (!contact.IsActive)
            {
                throw new ArgumentException("Contact is disabled!");
            }

            var userId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)?.ConvertToIntOrDefault(0);
            var contract = mapper.Map<Contract>(request);
            contract.ContractItems = new List<ContractItem>();
            contract.Creator = userId;
            foreach (var item in request.ContractItemRequests)
            {
                var contractItem = mapper.Map<ContractItem>(item);
                contractItem.Creator = userId;
                contract?.ContractItems?.Add(contractItem);
            }

            var result = await repositoryManager.Contract.CreateAsync(contract);
            await repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var contract = await repositoryManager.Contract.FindById(id);
            if (contract == null) return false;

            contract.IsActive = false;
            await repositoryManager.Contract.UpdateAsync(contract);
            return true;
        }

        public async Task<List<ContractResponse>> GetAll(ContractParameters parameters)
        {
            var contracts = await repositoryManager.Contract.FindByCondition(x => x.IsActive)
                .ProjectTo<ContractResponse>(mapper.ConfigurationProvider)
                .ToListAsync();
            return contracts;
        }

        public async Task<ContractResponse?> GetById(object id)
        {
            var contract = await repositoryManager.Contract.FindByCondition(x => x.Id.Equals(id) && x.IsActive)
                .ProjectTo<ContractResponse>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
            return contract;
        }

        public async Task<ContractDetailResponse?> GetDetail(int id)
        {
            var contract = await repositoryManager.Contract.FindByCondition(x => x.Id.Equals(id) && x.IsActive)
              .ProjectTo<ContractDetailResponse>(mapper.ConfigurationProvider)
              .FirstOrDefaultAsync();
            return contract;
        }

        public async Task Update(IRequest request)
        {
            var updateRequest = (ContractUpdateRequest)request;
            var contract = await repositoryManager.Contract.FindById(updateRequest.Id);
            if (contract == null)
            {
                throw new ArgumentException("Contract is not found!");
            }

            var contact = await repositoryManager.Contact.FindById(updateRequest.ContactId ?? 0);
            if (contact == null)
            {
                throw new ArgumentException("Contact is not found!");
            }

            if (!contact.IsActive)
            {
                throw new ArgumentException("Contact is disabled!");
            }

            if (contract.Stage == Stage.Opportunity && contract.CustomerId != updateRequest.CustomerId)
            {
                throw new ArgumentException("Cannot change customer!");
            }

            mapper.Map(request, contract);
            await repositoryManager.Contract.UpdateAsync(contract);

            foreach (var item in updateRequest.ContractItemRequests)
            {
                if (item.Id == 0)
                {
                    var userId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)?.ConvertToIntOrDefault(0);
                    var contractItem = mapper.Map<ContractItem>(item);
                    contractItem.ContractId = contract.Id;
                    contractItem.Creator = userId;
                    await repositoryManager.ContractItem.CreateAsync(contractItem);
                }
                else
                {
                    var contractItem = await repositoryManager.ContractItem.FindById(item.Id);
                    if (contractItem == null)
                        throw new ArgumentException($"ContractItem {item.Id} not found!");

                    mapper.Map(item, contractItem);
                    await repositoryManager.ContractItem.UpdateAsync(contractItem);
                }
            }
            await repositoryManager.SaveAsync();
        }
    }
}
