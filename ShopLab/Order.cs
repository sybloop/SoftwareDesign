using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLab
{
    class Order : IOrder
    {
        public Order() { }
        public Order(decimal totalCost, decimal weightInKG)
        {
            TotalCost = totalCost;
            WeightInKG = weightInKG;
            System.Console.WriteLine("Creating an order with cost " + this.TotalCost + " and weight " + this.WeightInKG);
        }
        public decimal TotalCost { get; set; }
        public decimal WeightInKG { get; set; }
        
    }
}
