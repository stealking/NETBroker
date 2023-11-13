using Core.Entities;
using Infrastructure.Context.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Context
{
    public class DataContext : IdentityDbContext<UserProfile, ApplicationRole, int>
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"), b => b.MigrationsAssembly("NETBroker"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new ContractItemConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new SaleProgramConfiguration());
            modelBuilder.ApplyConfiguration(new CommisionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DepositConfiguration());
            modelBuilder.ApplyConfiguration(new DateConfigConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CommissionConfigurationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QualificationConfiguration());
            modelBuilder.ApplyConfiguration(new ExpirationQualificationConfiguration());
            modelBuilder.ApplyConfiguration(new AnnualUssageQualificationConfiguration());

            //modelBuilder.Entity<UserProfile>().Navigation(x => x.CloserContracts).AutoInclude();
            //modelBuilder.Entity<Customer>().Navigation(x => x.Contracts).AutoInclude();
            //modelBuilder.Entity<Contact>().Navigation(x => x.Contracts).AutoInclude();
            //modelBuilder.Entity<Contract>().Navigation(x => x.ContractItems).AutoInclude();
            //modelBuilder.Entity<Supplier>().Navigation(x => x.Contracts).AutoInclude();
            //modelBuilder.Entity<Supplier>().Navigation(x => x.Deposits).AutoInclude();
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractItem> ContractItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SaleProgram> SalePrograms { get; set; }
        public DbSet<CommisionType> CommisionTypes { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<DateConfig> DateConfigs { get; set; }
        public DbSet<CommissionConfigurationType> CommissionConfigurationTypes { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
