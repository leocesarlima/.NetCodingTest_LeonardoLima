using Icatu.EmployeeManagerBusiness.Operation;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerWebAPI.Model;
using Icatu.EmployeeManagerWebAPI.Model.Validator;
using Microsoft.AspNetCore.Mvc;

namespace Icatu.EmployeeManagerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : BasesController<DepartmentDTO, Department, DepartmentDTOValidator>
    {
        private OperationDepartment _operationDepartment;
        public OperationDepartment OperationDepartment
        {
            get => _operationDepartment ?? (_operationDepartment = new OperationDepartment());
            set => _operationDepartment = value;
        }
    }
}
