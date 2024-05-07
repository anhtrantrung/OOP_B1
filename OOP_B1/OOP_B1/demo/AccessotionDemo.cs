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
        /// <summary>
        /// This method is used for testing the insertion of a product into the database.
        /// </summary>
        public void AccessotionTest()
        {
            Database.MakeSingleton().InsertTable("accesory", new Product(1, "accesory", 1));
        }
    }
}
