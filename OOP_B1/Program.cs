using OOP_B1.dao;
using OOP_B1.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1
{
    internal class Program
    {
        public int id;
        public string name;
        public int categoryId;  
        public object obj;
        static void Main(string[] args)
        {
            Program d = new Program();//gọi hàm trong Program
            Database database = Database.MakeSingleton();
            database.SelectTable("PRODUCTABLE", 8);
            Console.ReadLine();
        }
        
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getcategoryId()
        {
            return categoryId;
        }
        public void setcategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

    }

}

