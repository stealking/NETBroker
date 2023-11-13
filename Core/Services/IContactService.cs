using Core.Models.Requests.Contacts;
using Core.Models.Response.Contacts;

namespace Core.Services
{
    public interface IContactService :IServiceBase<ContactResponse, ContactRequest, ContactParameters>
    {
    }
}
