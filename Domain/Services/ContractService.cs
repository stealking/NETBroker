using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities;
using Core.Entities.Enums;
using Core.Models.Requests;
using Core.Models.Requests.Contracts;
using Core.Models.Response.Contracts;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ContractService : IContractService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        public ContractService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
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

            var contract = mapper.Map<Contract>(request);
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
            var contract = await repositoryManager.Contract.FindByCondition(x => x.Id.Equals(id))
                .ProjectTo<ContractResponse>(mapper.ConfigurationProvider)
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
            await repositoryManager.SaveAsync();
        }
    }
}
