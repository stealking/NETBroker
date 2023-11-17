using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Models.Response.ContractItemAttachments;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    internal class ContractItemAttachmentService : IContractItemAttachmentService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public ContractItemAttachmentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<ContractItemAttachmentResponse?> Find(int id)
        {
            var item = await repositoryManager.ContractItemAttachment.FindById(id);
            return mapper.Map<ContractItemAttachmentResponse>(item);
        }

        public async Task<List<ContractItemAttachmentResponse>> FindAttachments(int contractItemId)
        {
            var items = await repositoryManager.ContractItemAttachment.FindByCondition(x => x.ContractItemId ==  contractItemId)
                .ProjectTo<ContractItemAttachmentResponse>(mapper.ConfigurationProvider)
                .ToListAsync();
            return items ?? new List<ContractItemAttachmentResponse>();
        }
    }
}
