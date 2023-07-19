using SOLID.O_in_SOLID.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.O_in_SOLID.SD;

namespace SOLID.O_in_SOLID.Repository
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public ColorSpecification(Color color) {
            this.color = color;
        }
        public bool isSatisfied(Product entity)
        {
            return color == entity.Color;
        }
    }
}
