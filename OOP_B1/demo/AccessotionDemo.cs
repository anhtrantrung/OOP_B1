using OOP.entity;
using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class AccessotionDemo
    {
        public void AccessotionTest()
        {
            Database.MakeSingleton().InsertTable("accesory", new Product(1, "accesory", 1));
        }

        public void PrintProduct(Accessotion accessotion)
        {
            Console.WriteLine(accessotion.GetData());
        }
    }
}
