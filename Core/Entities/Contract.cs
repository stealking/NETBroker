﻿using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Contract : BaseCreateTable
    {
        private Contract()
        {
        }

        public Contract(int id, int supplierId, string? legalEntityName, int customerId, int contactId, int? closerId, int? fronterId, DateTime? soldDate, BillingChargeTypes billingChargeType, BillingTypes billingType, EnrollmentTypes enrollmentType, PricingTypes pricingType, int creator)
        {
            Id = id;
            SupplierId = supplierId;
            LegalEntityName = legalEntityName;
            CustomerId = customerId;
            ContactId = contactId;
            CloserId = closerId;
            FronterId = fronterId;
            SoldDate = soldDate;
            BillingChargeType = billingChargeType;
            BillingType = billingType;
            EnrollmentType = enrollmentType;
            PricingType = pricingType;
            Creator = creator;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "SupplierId is required.")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "LegalEntityName is required.")]
        public string? LegalEntityName { get; set; }

        [Required(ErrorMessage = "CustomerId is required.")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "ContactId is required.")]
        public int ContactId { get; set; }
        public int? CloserId { get; set; }
        public int? FronterId { get; set; }
        public DateTime? SoldDate { get; set; }

        [Required(ErrorMessage = "BillingChargeType is required.")]
        public BillingChargeTypes BillingChargeType { get; set; }

        [Required(ErrorMessage = "BillingType is required.")]
        public BillingTypes BillingType { get; set; }

        [Required(ErrorMessage = "EnrollmentType is required.")]
        public EnrollmentTypes EnrollmentType { get; set; }

        [Required(ErrorMessage = "PricingType is required.")]
        public PricingTypes PricingType { get; set; }

        public Supplier? Supplier { get; set; }
        public ICollection<ContractItem>? ContractItems { get; set; }
        public Contact? Contact { get; set; }
        [NotMapped]
        public UserProfile? Closer { get; set; }
        [NotMapped]
        public UserProfile? Fronter { get; set; }
        public Customer? Customer { get; set; }
    }
}
