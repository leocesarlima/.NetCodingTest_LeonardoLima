using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Icatu.EmployeeManagerBusiness.Operation;
using Icatu.EmployeeManagerWebAPI.Model;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerWebAPI.Model.Validator;

namespace Icatu.EmployeeManagerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BasesController<EmployeeDTO, Employee, EmployeeDTOValidator>
    {
        [HttpGet] // api/{controller}
        public ActionResult GetByIdDepartment(int idDepartment)
        {
            try
            {
                var retorno = OperationEmployee.GetByIdDepartment(idDepartment);
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        private OperationEmployee _operationEmployee;
        public OperationEmployee OperationEmployee
        {
            get => _operationEmployee ?? (_operationEmployee = new OperationEmployee());
            set => _operationEmployee = value;
        }
    }
}
