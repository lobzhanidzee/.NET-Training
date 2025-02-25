﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }
        public void ShipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
