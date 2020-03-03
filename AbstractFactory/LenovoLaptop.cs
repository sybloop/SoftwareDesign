using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class LenovoLaptop : ILaptop
    {
        private String make = "Lenovo";
        private String model;
         
        public string GetMake()
        {
            return this.make;
        }

        public string GetModel()
        {
            return this.model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }
    }
}
