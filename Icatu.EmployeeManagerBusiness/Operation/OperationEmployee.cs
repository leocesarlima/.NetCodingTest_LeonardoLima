using System.Collections.Generic;
using Icatu.EmployeeManagerDataAcess.Repository;
using Icatu.EmployeeManagerDataAcess.Repository.Interfaces;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerBusiness.Operation
{
    public class OperationEmployee : OperationBase<Employee>
    {
        private IRepositoryEmployee _repositoryEmployee;

        public OperationEmployee()
        {
            _repositoryEmployee = new RepositoryEmployee();
        }

        public IEnumerable<Employee> GetByIdDepartment(int idDepartment)
        {
            return _repositoryEmployee.GetByIdDepartment(idDepartment);
        }
    }
}
