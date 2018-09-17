using Icatu.EmployeeManagerDataAcess.Repository.Interfaces;
using Icatu.EmployeeManagerDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Icatu.EmployeeManagerDataAcess.Repository
{
    public class RepositoryEmployee: RepositoryBase<Employee>, IRepositoryEmployee
    {
        public IEnumerable<Employee> GetByIdDepartment(int idDepartment)
        {
            try
            {
                return Context.Set<Employee>().Where(x => x.IdDepartament == idDepartment);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
