using OOP.dao;
using OOP.entity;
using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class ProductDemo
    {
        public void ProductTest()
        {
            Database.MakeSingleton().InsertTable("product", new Product(1, "product", 1));
        }
    }
}
