using Microsoft.EntityFrameworkCore;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerDataAcess
{
    public class Context: DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmployeeManager;Integrated Security=True;MultipleActiveResultSets=true;");
            }
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

        
    }
}
