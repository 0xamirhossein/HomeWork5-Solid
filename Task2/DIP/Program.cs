using DIP.Interfaces;
using DIP.Services;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// first source is database");

            IProductDataSource dbSource = new DatabaseDataSource();
            ProductViewer viewer1 = new ProductViewer(dbSource);
            viewer1.ShowProducts();

            Console.WriteLine("// change to api");

            IProductDataSource apiSource = new ApiDataSource();
            ProductViewer viewer2 = new ProductViewer(apiSource);
            viewer2.ShowProducts();

            Console.WriteLine("// change to file");

            IProductDataSource fileSource = new FileDataSource();
            ProductViewer viewer3 = new ProductViewer(fileSource);
            viewer3.ShowProducts();
        }
    }
}