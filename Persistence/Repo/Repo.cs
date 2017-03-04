using Core.Interfaces.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using Persistence.Interfaces;

namespace Persistence.Repo
{
    public class Repo<TEntity> : IRepo<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> _entities;

        public Repo(IContext context) => _entities = context.Set<TEntity>();

        public void Add(TEntity entity) => _entities.Add(entity);

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.Where(predicate).ToList();
        }

        public TEntity Get(int id) => _entities.Find(id);

        public IEnumerable<TEntity> GetAll() => _entities.ToList();

        public void Remove(TEntity entity) => _entities.Remove(entity);

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _entities.SingleOrDefault(predicate);
        }
    }
}
