using FactoryContainer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryContainer.Services
{
    internal class ProductDataSourceFactory
    {
        private static IProductDataSource CreateDataSource(string sourceType)
        {
            return sourceType switch
            {
                "database" => new DatabaseDataSource(),
                "api" => new ApiDataSource(),
                "file" => new FileDataSource(),

                _ => throw new ArgumentException(
                    "Invalid data source.")
            };
        }

        public static ProductViewer Create(string sourceType)
        {
            IProductDataSource dataSource = CreateDataSource(sourceType);
                

            return new ProductViewer(dataSource);
        }
    }
}
