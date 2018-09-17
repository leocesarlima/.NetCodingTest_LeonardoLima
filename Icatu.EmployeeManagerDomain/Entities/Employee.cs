
namespace Icatu.EmployeeManagerDomain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        #region relationship

        public int IdDepartament { get; set; }
        
        #endregion
    }
}
