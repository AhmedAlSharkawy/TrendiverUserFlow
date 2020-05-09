using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommingSoon.DAL
{
    public interface IWriteRepository<TEntity,TId> where TEntity : class where TId : IEquatable<TId>
    {
        IWriteUnitOfWork UnitOfWork { get; }
        void Add(TEntity entity);
    }
}
