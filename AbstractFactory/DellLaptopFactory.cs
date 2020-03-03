using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class DellLaptopFactory : ILaptopFactory
    {
        private String factoryName = "Dell Factory";
        
        public ILaptop MakeLaptop(int budget)
        {
            DellLaptop lp = new DellLaptop();
            if (budget < 300)
            {               
                lp.SetModel("Inspiron");
            }
            else 
            {
                lp.SetModel("Latitude");    
            }
            return lp;
        }

        public string GetFactoryName()
        {
            return this.factoryName;
        }
    }
}
