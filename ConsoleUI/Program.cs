using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            }

            Console.WriteLine("\n-------Products With CategoryId value of '2' Listing--------\n");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            }

            Console.WriteLine("\n--------Unit Price Between 10 and 100--------\n");
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            }
        }
    }
}
