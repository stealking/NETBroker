using Core.Entities;
using Core.Models.Requests;
using Core.Models.Requests.Suppliers;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Domain.Services
{
    public sealed class SupplierService : ISupplierService
    {
        private IRepositoryManager repositoryManager;

        public SupplierService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }
        public async Task<Supplier> Create(Supplier supplier)
        {
            var result = await repositoryManager.Supplier.CreateAsync(supplier);
            await repositoryManager.SaveAsync();
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var supplier = (await repositoryManager.Supplier.FindByConditionAsync(x => x.Id == id)).FirstOrDefault();
            if (supplier != null)
            {
                supplier.IsActive = false;
                await Update(supplier);
                return true;
            }
            return false;
        }

        public async Task<List<Supplier>> GetAll()
        {
            var suppliers = await repositoryManager.Supplier.FindByCondition(x => x.IsActive).ToListAsync();
            return suppliers;
        }

        public async Task Update(Supplier supplier)
        {
            await repositoryManager.Supplier.UpdateAsync(supplier);
            await repositoryManager.SaveAsync();
        }

        public async Task<Supplier?> GetById(int id)
        {
            var suppliers = (await repositoryManager.Supplier.FindByConditionAsync(x => x.Id == id && x.IsActive)).FirstOrDefault();
            return suppliers;
        }

        public async Task<List<Supplier>> GetSuppliersAsync(SupplierParameters supplierParameters)
        {
            var suppliers = await repositoryManager.Supplier.FindByCondition(x => x.IsActive)
                .Skip(supplierParameters.Skip)
                .Take(supplierParameters.PageSize)
                .ToListAsync();
            return suppliers;
        }
    }
}
