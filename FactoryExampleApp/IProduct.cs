using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    interface IProduct
    {
        public String getProductType();
        public int getCost();
    }
}
