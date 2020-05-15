using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommingSoon.DAL
{
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        #region Members
        private DbContext context;
        #endregion
        #region CTOR
        public ReadUnitOfWork()
        {

        }
        #endregion
        #region Properties
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

        #endregion
    }
}