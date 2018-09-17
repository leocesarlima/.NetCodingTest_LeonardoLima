using System.Collections.Generic;
using Icatu.EmployeeManagerDataAcess.Repository;
using Icatu.EmployeeManagerDataAcess.Repository.Interfaces;

namespace Icatu.EmployeeManagerBusiness.Operation
{
    public class OperationBase<TEntity>
        where TEntity : class
    {
        private IRepositoryBase<TEntity> _repositoryBase;

        public OperationBase()
        {
            _repositoryBase = new RepositoryBase<TEntity>();
        }

        public virtual bool Save(TEntity obj)
        {
            return _repositoryBase.Save(obj);
        }

        public virtual bool Update(TEntity obj)
        {
            return _repositoryBase.Update(obj);
        }

        public virtual bool Delete(int id)
        {
            return _repositoryBase.Delete(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public virtual TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public virtual IEnumerable<TEntity> GetByFilter(string filter)
        {
            return _repositoryBase.GetByFilter(filter);
        }
    }
}
