using System;
using System.Collections.Generic;
using System.Linq;
using Icatu.EmployeeManagerDataAcess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Icatu.EmployeeManagerDataAcess.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable 
        where TEntity : class
    {
        protected Context Context;

        public RepositoryBase()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            var connection = @"Server=(localdb)\mssqllocaldb;Database=EmployeeManager;Trusted_Connection=True;ConnectRetryCount=0";

            optionsBuilder.UseSqlServer(connection);

            Context = new Context(optionsBuilder.Options);
        }

        public bool Save(TEntity obj)
        {
            try
            {
                Context.Add(obj);
                return Convert.ToBoolean(Context.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Update(TEntity obj)
        {
            try
            {
                Context.Update(obj);
                return Convert.ToBoolean(Context.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Context.Set<TEntity>().Remove(Context.Set<TEntity>().Find(id));
                return Convert.ToBoolean(Context.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return Context.Set<TEntity>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<TEntity> GetByFilter(string filtro)
        {
            try
            {
                return Context.Set<TEntity>()
                               .ToList()
                               .Where(x => x.GetType().GetProperties().Any(p => p.PropertyType == typeof(string)
                                                                             && ((string)p.GetValue(x, null)).Contains(filtro ?? string.Empty)));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return Context.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
