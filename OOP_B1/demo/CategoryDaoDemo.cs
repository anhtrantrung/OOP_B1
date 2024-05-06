using OOP.entity;
using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class CategoryDaoDemo 
    {
        private CategoryDemo categoryDemo;
        private CategoryDAO categoryDAO;

        public CategoryDaoDemo(CategoryDemo categoryDemo, CategoryDAO categoryDao)
        {
            this.categoryDemo = categoryDemo;
            this.categoryDAO = categoryDao;
        }

        public void CategoryDaoTest()
        {
            Console.WriteLine("\nInsert catagory:");
            categoryDAO.Insert(new Product(1, "catagory", 1));
            PrintData();

            Console.WriteLine("\nUpdate catagory:");
            categoryDAO.Update(new Product(5, "catagory", 5));

            Console.WriteLine("\nDelete catagory:");
            categoryDAO.Delete(new Product(1, "catagory", 1), 1);
            PrintData();

            Console.WriteLine("\nTruncate catagory:");
            categoryDAO.Truncate(new Product(1, "catagory", 1));
            PrintData();
        }

        public void PrintData()
        {
            foreach (BaseRow row in Database.MakeSingleton().SelectTable("catagory"))
            {
                Console.WriteLine(row.GetData());
            }
        }
    }
}
