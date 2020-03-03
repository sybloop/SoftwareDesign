using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    class ComplexProduct : IProduct
    {
        private String productType;
        private int cost;
        public ComplexProduct()
        {
            productType = "Complex";
            cost = 100;
        }
        public String getProductType()
        {
            return productType;
        }
        public int getCost()
        {
            return cost;
        }
    }   
}
