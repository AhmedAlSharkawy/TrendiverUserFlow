using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommingSoon.DAL
{
    public interface IReadUnitOfWork
    {
        DbContext Context { get; }
    }
}
