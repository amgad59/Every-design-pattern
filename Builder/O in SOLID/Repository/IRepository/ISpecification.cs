using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O_in_SOLID.Repository.IRepository
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T entity);
    }
}
