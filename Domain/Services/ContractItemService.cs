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
        private readonly IFileService fileService;
        private readonly string folderPath = "ContractItemAttchments";

        public ContractItemService(IRepositoryManager repositoryManager, IMapper mapper, IFileService fileService)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.fileService = fileService;
        }

        public async Task<bool> Create(IRequest request)
        {
            var createRequest = (ContractItemRequest)request;
            var item = mapper.Map<ContractItem>(createRequest);
            foreach (var file in createRequest.ContractItemAttachments)
            {
                var filePath = await fileService.UploadFileAsync(file.FileData, folderPath);
                if (!string.IsNullOrEmpty(filePath))
                {
                    var fileType = Path.GetExtension(file?.FileData?.FileName);
                    var contractItemAttachment = new ContractItemAttachment(filePath, file?.FileData?.FileName, fileType);
                    item.Attachments.Add(contractItemAttachment);
                }
            }

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
            var updateRequest = (ContractItemRequest)request;
            var contractItem = await repositoryManager.ContractItem.FindByCondition(x => x.Id == updateRequest.Id, x => x.Attachments).FirstOrDefaultAsync();
            if (contractItem == null)
            {
                throw new ArgumentException("ContractItem not found!");
            }

            mapper.Map(updateRequest, contractItem);

            var currentAttachmentIds = contractItem.Attachments.Select(x => x.Id).ToList();
            var newAttachments = updateRequest.ContractItemAttachments.Where(x => x.Id == 0).ToList();
            foreach (var attachment in newAttachments)
            {
                var filePath = await fileService.UploadFileAsync(attachment.FileData, folderPath);
                if (!string.IsNullOrEmpty(filePath))
                {
                    var fileType = Path.GetExtension(attachment?.FileData?.FileName);
                    var contractItemAttachment = new ContractItemAttachment(filePath, attachment?.FileData?.FileName, fileType);
                    contractItem.Attachments.Add(contractItemAttachment);
                }
            }

            var removeAttachmentIds = currentAttachmentIds.Except(updateRequest.ContractItemAttachments.Where(x => x.Id != 0).Select(x => x.Id).ToList());
            foreach (var id in removeAttachmentIds)
            {
                var attachment = await repositoryManager.ContractItemAttachment.FindById(id);
                if (attachment != null)
                {
                    await repositoryManager.ContractItemAttachment.DeleteAsync(attachment);
                }
            }
            await repositoryManager.ContractItem.UpdateAsync(contractItem);
            await repositoryManager.SaveAsync();
        }
    }
}
