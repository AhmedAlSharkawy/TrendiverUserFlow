using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommingSoon.DAL
{
    public interface IReadRepo<TEntity,TId> where TEntity: class where TId: IEquatable<TId>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetItem(TId id);
    }
}
