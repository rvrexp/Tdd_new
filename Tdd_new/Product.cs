﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_new
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double GetPrice(Customer customer)
        {
            if (customer.IsPlatinum)
            {
                return Price * .8;
            }
            return Price;
        }
     
    }
}