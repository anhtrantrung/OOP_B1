using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;
using OOP_B1.dao;
using OOP_B1.demo;

namespace OOP.demo
{
    class ProductDaoDemo
    {
        private ProductDemo productDemo;
        private ProductDAO productDAO;

        /// <summary>
        /// Initializes a new instance of the ProductDaoDemo class with the specified ProductDemo and ProductDAO instances.
        /// </summary>
        /// <param name="productDemo"></param>
        /// <param name="productDAO"></param>
        public ProductDaoDemo(ProductDemo productDemo, ProductDAO productDAO)
        {
            this.productDemo = productDemo;
            this.productDAO = productDAO;
        }

        /// <summary>
        /// This method tests the functionality of the ProductDaoTest by performing insert, update, delete, and truncate operations.
        /// </summary>
        public void ProductDaoTest()
        {
            Console.WriteLine("\nInsert product:");
            productDAO.Insert( new Product(1, "product", 1));
            PrintData();

            Console.WriteLine("\nUpdate product:");
            productDAO.Update( new Product(5, "product", 5));

            Console.WriteLine("\nDelete product:");
            productDAO.Delete(new Product(1, "product", 1), 1);
            PrintData();

            Console.WriteLine("\nTruncate product:");
            productDAO.Truncate(new Product(1, "product", 1));
            PrintData();
        }

        /// <summary>
        /// Prints the data of all rows in the "product" table to the console.
        /// </summary>
        public void PrintData()
        {
            foreach (BaseRow row in Database.MakeSingleton().SelectTable("product"))
            {
                Console.WriteLine(row.GetData());
            }
        }
    }
}