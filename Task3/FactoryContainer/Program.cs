using FactoryContainer.Interfaces;
using FactoryContainer.Services;

namespace FactoryContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Container");
            Console.WriteLine("1- Database");
            Console.WriteLine("2- API");
            Console.WriteLine("3- File");

            Console.Write("Please select a source: ");

            string choice = Console.ReadLine();

            string sourceType;

            switch (choice)
            {
                case "1":
                    sourceType = "database";
                    break;

                case "2":
                    sourceType = "api";
                    break;

                case "3":
                    sourceType = "file";
                    break;

                default:
                    Console.WriteLine("Your choice is invalid.");
                    return;
            }

            ProductViewer viewer = ProductDataSourceFactory.Create(sourceType);
                

            viewer.ShowProducts();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}