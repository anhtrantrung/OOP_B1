using OOP_B1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.demo
{
    internal class CategoryDaoDemo : Database
    {
       
        public object objTest;
        public void InsertTest()
        {
            InsertTable("PRODUCTABLE", objTest);
        }

        public void FindAllTest()
        {
            SelectTable("CATAGORY", objTest);
        }

        public void UpdateTest()
        {
            UpdateTable("ACCESORY", objTest);
        }
    }
}
