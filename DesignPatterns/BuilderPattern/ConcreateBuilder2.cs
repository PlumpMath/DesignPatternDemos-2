using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteBuilder2 : IBuilder
    {
        private Product product;
        public ConcreteBuilder2()
        {
            this.product = new Product();
        }
        public void BuildPartA()
        {
            this.product.Add("PartX");
        }

        public void BuildPartB()
        {
            this.product.Add("PartB");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
