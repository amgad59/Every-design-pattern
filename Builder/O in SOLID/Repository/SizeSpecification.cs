using SOLID.O_in_SOLID.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.O_in_SOLID.SD;

namespace SOLID.O_in_SOLID.Repository
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool isSatisfied(Product entity)
        {
            return entity.Size == size;
        }
    }
}
