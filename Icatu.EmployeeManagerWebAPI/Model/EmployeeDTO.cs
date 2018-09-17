using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Icatu.EmployeeManagerWebAPI.Model
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        #region relationship

        public int IdDepartament { get; set; }

        #endregion
    }
}
