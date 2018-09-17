using System.Collections.Generic;

namespace Icatu.EmployeeManagerWebAPI.Model
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EmployeeDTO> Employees { get; set; }
    }
}
