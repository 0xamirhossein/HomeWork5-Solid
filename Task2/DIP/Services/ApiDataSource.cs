using DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Services
{
    internal class ApiDataSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            Console.WriteLine("Read from api");
            return new List<string> { "first product from api ", "second product  from api  " };
        }
    }
}
