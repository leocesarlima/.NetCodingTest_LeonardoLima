using Icatu.EmployeeManagerDataAcess.Repository;
using Icatu.EmployeeManagerDataAcess.Repository.Interfaces;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerBusiness.Operation
{
    public class OperationDepartment : OperationBase<Department>
    {
        private IRepositoryDepartment _repositoryDeparment;

        public OperationDepartment()
        {
            _repositoryDeparment = new RepositoryDepartment();
        }
    }
}
