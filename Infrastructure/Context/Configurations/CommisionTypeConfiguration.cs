using Core.Entities;
using Core.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class CommisionTypeConfiguration : IEntityTypeConfiguration<CommisionType>
    {
        public void Configure(EntityTypeBuilder<CommisionType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.HasOne(x => x.DateConfig).WithOne(x => x.CommisionTypes).HasForeignKey<DateConfig>(p => p.CommisionTypeId);
            builder.HasDiscriminator()
               .HasValue<ContractUpfront>("ContractUpfront")
               .HasValue<PercentageContractResidual>("PercentageContractResidual")
               .HasValue<QuarterlyUpfront>("QuarterlyUpfront")
               .HasValue<AnnualUpfront>("AnnualUpfront")
               .HasValue<Bridge>("Bridge")
               .HasValue<FirstAnnualUpfront>("FirstAnnualUpfront")
               .HasValue<FirstAnnualUpfront25kMax>("FirstAnnualUpfront25kMax")
               .HasValue<PercentageAdderResidual>("PercentageAdderResidual")
               .HasValue<PercentageFirstAnnualRemainderResidual>("PercentageFirstAnnualRemainderResidual");
        }
    }

    public class ContractUpfrontConfiguration : IEntityTypeConfiguration<ContractUpfront>
    {
        public void Configure(EntityTypeBuilder<ContractUpfront> builder)
        {
            builder.HasData(
                new ContractUpfront(1, "ContractUpfront", ProgramAdderType.Override, 0.007m, 0.5m) { Id = 1 }
            );
        }
    }

    public class PercentageContractResidualConfiguration : IEntityTypeConfiguration<PercentageContractResidual>
    {
        public void Configure(EntityTypeBuilder<PercentageContractResidual> builder)
        {
            builder.HasData(
                new PercentageContractResidual(1, "PercentageContractResidual", ProgramAdderType.Override, 0.007m, 0.5m) { Id = 2 }
            );
        }
    }

    public class QuarterlyUpfrontConfiguration : IEntityTypeConfiguration<QuarterlyUpfront>
    {
        public void Configure(EntityTypeBuilder<QuarterlyUpfront> builder)
        {
            builder.HasData(
                new QuarterlyUpfront(1, "QuarterlyUpfront", ProgramAdderType.Override, 0.007m, 0.5m) { Id = 3 }
            );
        }
    }
}
