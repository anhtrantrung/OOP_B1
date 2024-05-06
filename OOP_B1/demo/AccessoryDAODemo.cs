using OOP.entity;
using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class AccessoryDAODemo
    {
        private AccessotionDemo accessotionDemo;
        private AccessoryDAO accessoryDAO;
        public AccessoryDAODemo(AccessotionDemo accessotionDemo, AccessoryDAO accessoryDAO)
        {
            this.accessotionDemo = accessotionDemo;
            this.accessoryDAO = accessoryDAO;
        }

        public void AccessotionDaoTest()
        {
            Console.WriteLine("\nInsert accesory:");
            accessoryDAO.Insert(new Product(1, "accesory", 1));
            PrintData();

            Console.WriteLine("\nUpdate accesory:");
            accessoryDAO.Update(new Product(5, "accesory", 5));

            Console.WriteLine("\nDelete product:");
            accessoryDAO.Delete(new Product(1, "accesory", 1), 1);
            PrintData();

            Console.WriteLine("\nTruncate product:");
            accessoryDAO.Truncate(new Product(1, "accesory", 1));
            PrintData();
        }

        public void PrintData()
        {
            foreach (BaseRow row in Database.MakeSingleton().SelectTable("accesory"))
            {
                Console.WriteLine(row.GetData());
            }
        }
    }
}
