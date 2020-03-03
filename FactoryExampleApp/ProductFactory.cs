using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    class ProductFactory
    {
        //private Product myProduct;
        public ProductFactory() { }
        public static IProduct makeProduct(int budget)
        {
            if (budget < 100)
            {
                return new SimpleProduct();
            }
            else
            {
                return new ComplexProduct();
            }
        }
    }


}
