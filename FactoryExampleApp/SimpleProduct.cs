using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    class SimpleProduct : IProduct
    {
        private String productType;
        private int cost;
        public SimpleProduct()
        {
            this.productType = "Simple";
            this.cost = 50;
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
