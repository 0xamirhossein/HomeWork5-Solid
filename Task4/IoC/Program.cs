using IoC.Interfaces;
using IoC.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IoC Container");
            Console.WriteLine("1- Database");
            Console.WriteLine("2- API");
            Console.WriteLine("3- File");

            Console.Write("Please select a source: ");

            string choice = Console.ReadLine();

            var services = new ServiceCollection();

            switch (choice)
            {
                case "1":
                    services.AddTransient<
                        IProductDataSource,
                        DatabaseDataSource>();
                    break;

                case "2":
                    services.AddTransient<IProductDataSource,ApiDataSource>();
                    break;

                case "3":
                    services.AddTransient<IProductDataSource,FileDataSource>();
                    break;

                default:
                    Console.WriteLine("your choice is invalid.");
                    return;
            }


            services.AddTransient<ProductViewer>();


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
                   
            {
                ProductViewer viewer = serviceProvider.GetRequiredService<ProductViewer>();
                   
                        

                viewer.ShowProducts();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}