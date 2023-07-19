using SOLID.O_in_SOLID.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O_in_SOLID.Repository
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public bool isSatisfied(T entity)
        {
            return first.isSatisfied(entity) && second.isSatisfied(entity);
        }
    }
}
