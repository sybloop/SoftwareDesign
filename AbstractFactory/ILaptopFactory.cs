using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ILaptopFactory
    {
        ILaptop MakeLaptop(int budget);
        String GetFactoryName();
    }
}
