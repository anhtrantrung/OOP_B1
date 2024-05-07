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

        /// <summary>
        /// Initializes a new instance of the AccessoryDAODemo class with the specified accessotionDemo and accessoryDAO instances.
        /// </summary>
        /// <param name="accessotionDemo"></param>
        /// <param name="accessoryDAO"></param>
        public AccessoryDAODemo(AccessotionDemo accessotionDemo, AccessoryDAO accessoryDAO)
        {
            this.accessotionDemo = accessotionDemo;
            this.accessoryDAO = accessoryDAO;
        }

        /// <summary>
        /// This method tests the functionality of the AccessoryDAO by performing insert, update, delete, and truncate operations.
        /// </summary>
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

        /// <summary>
        /// Prints the data of all rows in the "accesory" table to the console.
        /// </summary>
        public void PrintData()
        {
            foreach (BaseRow row in Database.MakeSingleton().SelectTable("accesory"))
            {
                Console.WriteLine(row.GetData());
            }
        }
    }
}
