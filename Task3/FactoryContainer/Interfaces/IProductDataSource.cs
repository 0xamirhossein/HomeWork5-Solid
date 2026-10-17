using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryContainer.Interfaces
{
    public interface IProductDataSource
    {
        List<string> GetProducts();
    }
}
