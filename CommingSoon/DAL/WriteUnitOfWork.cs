using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommingSoon.DAL
{
    public class WriteUnitOfWork : IWriteUnitOfWork,IDisposable
    {
        #region Members
        private bool _isDisposed = false;
        private DbContext context;
        #endregion

        #region CTOR
        public WriteUnitOfWork()
        {
        }
        #endregion
        public DbContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new Entities();
                }
                return context;
            }
        }

        public bool SaveChanges()
        {
            try
            {
                return context.SaveChanges() > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }


        #region IDisposable
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                context?.Dispose();
            }
        }


        #endregion
    }
}