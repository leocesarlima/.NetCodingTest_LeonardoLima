using Icatu.EmployeeManagerDomain.Entities;
using System.Collections.Generic;

namespace Icatu.EmployeeManagerDataAcess.Repository.Interfaces
{
    public interface IRepositoryEmployee : IRepositoryBase<Employee>
    {
        IEnumerable<Employee> GetByIdDepartment(int idDepartment);
    }
}
