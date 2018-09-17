using System.Collections.Generic;

namespace Icatu.EmployeeManagerDataAcess.Repository.Interfaces
{
    public interface IRepositoryBase <TEntity> 
        where TEntity: class
    {
        bool Save(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetByFilter(string filtro);
    }
}
