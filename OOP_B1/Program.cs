using OOP.demo;
using OOP.entity;
using OOP_B1.dao;
using OOP_B1.demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_B1
{
    internal class Program
    {
        private ProductDaoDemo productDaoDemo = new ProductDaoDemo(new ProductDemo(), new ProductDAO());
        private CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo(new CategoryDemo(), new CategoryDAO());
        private AccessoryDAODemo accessoryDAODemo = new AccessoryDAODemo(new AccessotionDemo(), new AccessoryDAO());

        static void Main(string[] args)
        {
            Program program = new Program();
            program.TestProduct();
        }

        private void TestProduct()
        {
            productDaoDemo.ProductDaoTest();
        }

        private void TestCategory()
        {
            categoryDaoDemo.CategoryDaoTest();
        }

        private void AccessoryProduct()
        {
            accessoryDAODemo.AccessotionDaoTest();
        }
    }
}



