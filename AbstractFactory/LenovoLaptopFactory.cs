using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class LenovoLaptopFactory : ILaptopFactory
    {
        String factoryName = "Lenovo Factory";
        public ILaptop MakeLaptop(int budget)
        {
            LenovoLaptop lp = new LenovoLaptop();
            if (budget < 300)
            {
                lp.SetModel("IdeaPad");
            }
            else
            {
                lp.SetModel("ThinkPad");
            }
            return lp;
        }
        public string GetFactoryName()
        {
            return this.factoryName;
        }
    }
}
