using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities;
using Core.Models.Requests;
using Core.Models.Requests.ContractItems;
using Core.Models.Requests.Contracts;
using Core.Models.Response.ContractItems;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ContractItemService : IContractItemService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public ContractItemService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<bool> Create(IRequest request)
        {
            var createRequest = (ContractItemRequest)request;
            var item =  mapper.Map<ContractItem>(createRequest);
            await repositoryManager.ContractItem.CreateAsync(item);
            await repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var item = await repositoryManager.ContractItem.FindById(id);
            if (item == null)
            {
                throw new ArgumentException("ContractItem not found!");
            }

            item.IsActive = false;
            await repositoryManager.ContractItem.UpdateAsync(item);
            await repositoryManager.SaveAsync();
            return true;
        }

        public async Task<List<ContractItemResponse>> GetAll(ContractItemParameters parameter)
        {
            var result = await repositoryManager.ContractItem.FindByCondition(x => x.IsActive)
                .Skip(parameter.Skip)
                .Take(parameter.PageSize)
                .ProjectTo<ContractItemResponse>(mapper.ConfigurationProvider)
                .ToListAsync();
            return result;
        }

        public async Task<ContractItemResponse?> GetById(object id)
        {
            var item = await repositoryManager.ContractItem.FindById(id);
            if (item == null)
            {
                throw new ArgumentException("ContractItem not found!");
            }
            return mapper.Map<ContractItemResponse>(item);
        }

        public async Task Update(IRequest request)
        {
            var updateRequest = (ContractUpdateRequest)request;
            var contractItem = await repositoryManager.ContractItem.FindById(updateRequest.Id);
            if (contractItem == null)
            {
                throw new ArgumentException("ContractItem not found!");
            }

            mapper.Map(updateRequest, contractItem);
            await repositoryManager.ContractItem.UpdateAsync(contractItem);
            await repositoryManager.SaveAsync();
        }
    }
}
