using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommingSoon.DAL
{
    public class WriteRepository<TEntity, TId> : IWriteRepository<TEntity, TId> where TEntity : class
                                                                  where TId : IEquatable<TId>
    {
        #region Members
        private IWriteUnitOfWork _unitOfWork;

        private DbContext _context;
        #endregion

        #region CTOR
        public WriteRepository(IWriteUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("IWriteUnitOfWork can not be null!");
            }
            _unitOfWork = unitOfWork;
            _context = unitOfWork.Context as DbContext;

            if (_context == null)
            {
                throw new ArgumentNullException("IWriteUnitOfWork.Context is null or not of type DbContext!");
            }
        }

        #endregion
        #region IWriteRepository

        public IWriteUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        public void Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}