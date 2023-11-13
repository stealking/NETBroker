using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities;
using Core.Models.Requests;
using Core.Models.Requests.Suppliers;
using Core.Models.Response.Suppliers;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public sealed class SupplierService : ISupplierService
    {
        private IRepositoryManager repositoryManager;
        private IMapper mapper;

        public SupplierService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<SupplierResponse?> GetById(object id)
        {
            var supplier = await repositoryManager.Supplier.FindByCondition(x => x.Id.Equals(id) && x.IsActive).FirstOrDefaultAsync();
            return mapper.Map<SupplierResponse>(supplier);
        }

        public async Task<List<SupplierResponse>> GetAll(SupplierParameters parameter)
        {
            var suppliers = await repositoryManager.Supplier.FindByCondition(x => x.IsActive)
              .Skip(parameter.Skip)
              .Take(parameter.PageSize)
                .ProjectTo<SupplierResponse>(mapper.ConfigurationProvider)
              .ToListAsync();
            return suppliers;
        }

        public async Task<bool> Create(IRequest request)
        {
            var supplierRequest = (SupplierRequest)request;
            var supplier = mapper.Map<Supplier>(supplierRequest);
            await repositoryManager.Supplier.CreateAsync(supplier);
            await repositoryManager.SaveAsync();
            return true;
        }

        public async Task Update(IRequest request)
        {
            var updateRequest = (SupplierUpdateRequest)request;
            var supplier = await repositoryManager.Supplier.FindById(updateRequest.Id);
            if (supplier == null)
            {
                throw new ArgumentNullException(nameof(supplier));
            }

            mapper.Map(request, supplier);
            await repositoryManager.Supplier.UpdateAsync(supplier);
            await repositoryManager.SaveAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var supplier = await repositoryManager.Supplier.FindById(id);
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));

            supplier.IsActive = false;
            await repositoryManager.Supplier.UpdateAsync(supplier);
            await repositoryManager.SaveAsync();
            return true;
        }
    }
}
