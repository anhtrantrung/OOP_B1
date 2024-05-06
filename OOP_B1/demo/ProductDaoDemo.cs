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
        public ProductDaoDemo(ProductDemo productDemo, ProductDAO productDAO)
        {
            this.productDemo = productDemo;
            this.productDAO = productDAO;
        }

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

        public void PrintData()
        {
            foreach (BaseRow row in Database.MakeSingleton().SelectTable("product"))
            {
                Console.WriteLine(row.GetData());
            }
        }
    }
}