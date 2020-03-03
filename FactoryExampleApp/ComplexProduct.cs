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
            this.productType = "Complex";
            this.cost = 100;
        }
        public String getProductType()
        {
            return this.productType;
        }
        public int getCost()
        {
            return this.cost;
        }
    }   
}
