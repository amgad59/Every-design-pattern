using SOLID.O_in_SOLID.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O_in_SOLID.Repository
{
    public class FilterProduct : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> Items, ISpecification<Product> specs)
        {
            foreach (var item in Items)
            {
                if(specs.isSatisfied(item))
                    yield return item;
            }
        }
    }
}
