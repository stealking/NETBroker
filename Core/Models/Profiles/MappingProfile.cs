using AutoMapper;
using Core.Entities;
using Core.Models.Requests.ContractItemAttachments;
using Core.Models.Requests.ContractItems;
using Core.Models.Requests.Contracts;
using Core.Models.Requests.Suppliers;
using Core.Models.Requests.Users;
using Core.Models.Response.ContractItemAttachments;
using Core.Models.Response.ContractItems;
using Core.Models.Response.Contracts;
using Core.Models.Response.Reports;
using Core.Models.Response.Suppliers;
using Core.Models.Response.Users;

namespace Core.Models.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserProfile, UserResponse>();
            CreateMap<UserResponse, UserProfile>();
            CreateMap<UserRequest, UserProfile>();
            CreateMap<UserUpdateRequest, UserProfile>();

            CreateMap<Supplier, SupplierResponse>();
            CreateMap<SupplierRequest, Supplier>();
            CreateMap<SupplierUpdateRequest, Supplier>();

            CreateMap<ContractRequest, Contract>();
            CreateMap<ContractUpdateRequest, Contract>();
            CreateMap<Contract, ContractResponse>()
                .ForMember(p => p.BillingChargeType, opt => opt.MapFrom(x => x.BillingChargeType.ToString()))
                .ForMember(p => p.BillingType, opt => opt.MapFrom(x => x.BillingType.ToString()))
                .ForMember(p => p.EnrollmentType, opt => opt.MapFrom(x => x.EnrollmentType.ToString()))
                .ForMember(p => p.PricingType, opt => opt.MapFrom(x => x.PricingType.ToString()))
                .ForMember(p => p.SupplierName, opt => opt.MapFrom(x => x.Supplier.Name))
                .ForMember(p => p.ContactName, opt => opt.MapFrom(x => x.Contact.Name))
                .ForMember(p => p.CloserName, opt => opt.MapFrom(x => x.Closer.FullName))
                .ForMember(p => p.FronterName, opt => opt.MapFrom(x => x.Fronter.FullName))
                .ForMember(p => p.FronterName, opt => opt.MapFrom(x => x.Fronter.FullName))
                .ForMember(p => p.CustomerName, opt => opt.MapFrom(x => x.Customer.Name))
                .ReverseMap();

            CreateMap<Contract, ContractDetailResponse>()
              .ForMember(p => p.BillingChargeType, opt => opt.MapFrom(x => x.BillingChargeType.ToString()))
              .ForMember(p => p.BillingType, opt => opt.MapFrom(x => x.BillingType.ToString()))
              .ForMember(p => p.EnrollmentType, opt => opt.MapFrom(x => x.EnrollmentType.ToString()))
              .ForMember(p => p.PricingType, opt => opt.MapFrom(x => x.PricingType.ToString()))
              .ForMember(p => p.SupplierName, opt => opt.MapFrom(x => x.Supplier.Name))
              .ForMember(p => p.ContactName, opt => opt.MapFrom(x => x.Contact.Name))
              .ForMember(p => p.CloserName, opt => opt.MapFrom(x => x.Closer.FullName))
              .ForMember(p => p.FronterName, opt => opt.MapFrom(x => x.Fronter.FullName))
              .ForMember(p => p.FronterName, opt => opt.MapFrom(x => x.Fronter.FullName))
              .ForMember(p => p.CustomerName, opt => opt.MapFrom(x => x.Customer.Name))
              .ForMember(p => p.ContractItems, opt => opt.MapFrom(x => x.ContractItems.Where(x => x.IsActive)))
              .ReverseMap();

            CreateMap<ContractItem, ContractItemResponse>();
            CreateMap<ContractItemRequest, ContractItem>();

            CreateMap<ContractItemAttachmentRequest,  ContractItemAttachment>();
            CreateMap<ContractItemAttachment, ContractItemAttachmentResponse>().ReverseMap();

            CreateMap<ContractItem, SummaryDashBoardReportDTO>()
                .ForMember(p => p.AnnualUsage, opt => opt.MapFrom(x => x.AnnualUsage))
                .ForMember(p => p.SupplierId, opt => opt.MapFrom(x => x.Contract.SupplierId))
                .ForMember(p => p.SupplierName, opt => opt.MapFrom(x => x.Contract.Supplier.Name));
        }
    }
}
