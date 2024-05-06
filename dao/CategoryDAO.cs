using OOP_B1.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    
    internal class CategoryDAO 
    {
        const string CATAGORY = "catagory";
        //public Database database;

        //public CategoryDAO(int id, string name, int categoryId) : base(id, name, categoryId)
        //{
        //}

        //public bool Insert(object row)
        //{
        //    try
        //    {
        //        database.InsertTable("category", row);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        public static CategoryDAO instance;
        public static CategoryDAO MakeSingleton()
        {
            if (instance == null)
            { instance = new CategoryDAO(); }
            return instance; ;
        }
        public void Insert(Category category)
        {
            Console.WriteLine("CategoryDAO ");
            Console.WriteLine("Please enter data ");
            string name = Console.ReadLine();
            Database database = Database.MakeSingleton();
           

            if (name == CATAGORY)
            {
                //Product product = new Product(1, "produc", 1);
                database.InsertTable("catagory", category);
                Insert(category);
                return;
            }

        }
        
    }
}
