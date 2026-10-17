using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interfaces
{
    public interface IProductDataSource
    {
        List<string> GetProducts();
        //commit for change
    }
}
