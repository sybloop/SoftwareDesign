using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ILaptop
    {
        String GetMake();
        String GetModel();
        void SetModel(String model);
    }
}
