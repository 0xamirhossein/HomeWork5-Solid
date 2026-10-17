using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.Interfaces
{
    public interface IProductDataSource
    {
        List<string> GetProducts();
    }
}
