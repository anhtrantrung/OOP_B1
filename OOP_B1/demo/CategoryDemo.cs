using OOP.entity;
using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class CategoryDemo
    {
        public void CategoryTest()
        {
            Database.MakeSingleton().InsertTable("catagory", new Product(2, "catagory", 2));
        }
        public void PrintProduct(Category category)
        {
            Console.WriteLine(category.GetData());
        }
    }
}
