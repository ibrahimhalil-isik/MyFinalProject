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
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            //}

            //Console.WriteLine("\n-------Products With CategoryId value of '1' Listing--------\n");
            //foreach (var product in productManager.GetAllByCategoryId(1))
            //{
            //    Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            //}

            //Console.WriteLine("\n--------Unit Price Between 10 and 100--------\n");
            //foreach (var product in productManager.GetByUnitPrice(40, 100))
            //{
            //    Console.WriteLine(product.ProductName + " : " + product.UnitPrice);
            //}

            //Console.WriteLine("\n-------- Product ile Category join edilmiş hal ------------\n");
            //foreach (var product in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(product.ProductName + " : " + product.CategoryName);
            //}

            Console.WriteLine("\n-------- Kurumsal mimari ------------\n");

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " : " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
