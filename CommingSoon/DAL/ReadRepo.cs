using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommingSoon.DAL
{
    public class ReadRepo<TEntity,TId> : IReadRepo<TEntity,TId> where TEntity: class where TId : IEquatable<TId>
    {
        #region Members
        private IReadUnitOfWork readUnitOfWork;
        private DbContext context;
        #endregion

        #region CTOR
        public ReadRepo(IReadUnitOfWork _readUnitOfWork)
        {
            readUnitOfWork = _readUnitOfWork;
            context = _readUnitOfWork.Context;
        }

        #endregion
        #region Methods

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsNoTracking().AsQueryable();
        }

        public TEntity GetItem(TId id)
        {
            return context.Set<TEntity>().Find(id);
        }
        #endregion
    }
}