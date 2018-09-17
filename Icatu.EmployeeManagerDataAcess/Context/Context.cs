using Microsoft.EntityFrameworkCore;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerDataAcess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EmployeeManager;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(s => s.Id)
                .IsRequired();

                entity.Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();

                entity.Property(s => s.Mail)
                   .HasMaxLength(50)
                   .IsRequired();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(s => s.Id);

                entity.Property(s => s.Id)
                    .IsRequired();

                entity.Property(s => s.Name)
                   .HasMaxLength(100)
                   .IsRequired();

                entity.HasMany(x => x.Employees)
                    .WithOne()
                    .HasForeignKey(x => x.IdDepartament);
            });
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
