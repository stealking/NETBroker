using AutoMapper;
using Core.Entities;
using Core.Models.Requests.Contacts;
using Core.Models.Response.Contacts;
using Core.Repositories;
using Core.Services;

namespace Domain.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public ContactService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public Task<bool> Create(ContactRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactResponse>> GetAll(ContactParameters parameter)
        {
            throw new NotImplementedException();
        }

        public Task<ContactResponse?> GetById(object id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ContactRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
