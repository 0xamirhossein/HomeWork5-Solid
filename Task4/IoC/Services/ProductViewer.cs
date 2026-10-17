using IoC.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Services
{
    internal class ProductViewer
    {
        private readonly IProductDataSource _dataSource;


        public ProductViewer(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void ShowProducts()
        {
            var products = _dataSource.GetProducts();

            Console.WriteLine("products");
            foreach (var product in products)
            {
                Console.WriteLine($" - {product}");
            }
        }
    }
}
