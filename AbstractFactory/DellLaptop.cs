using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class DellLaptop:ILaptop
    {
        private String make ="Dell";
        private String model;
                
        public String GetMake()
        {
            return this.make;
        }
       
        public String GetModel()
        {
            return this.model;
        }

        public void SetModel(String model)
        {
            this.model = model;
        }
    }
}
