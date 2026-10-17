using IoC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Services
{
    internal class FileDataSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            Console.WriteLine("Read from database");
            return new List<string> { "first product from database", "second product from database " };
        }

    }
}
