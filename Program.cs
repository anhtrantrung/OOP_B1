using OOP_B1.dao;
using OOP_B1.entity;
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

        const string PRODUCTABLE = "produc";
        const string CATAGORY = "catagory";
        const string ACCESORY = "accesory";
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Options();


        }
        private void Options()
        {
            Console.WriteLine("\n1-Insert");
            Console.WriteLine("2-Select");
            Console.WriteLine("3-Update");
            Console.WriteLine("4-Delete");
            Console.WriteLine("5-DeleteAll");
            Console.WriteLine("6-Exit\n");
            int iselect = Convert.ToInt32(Console.ReadLine());
            switch (iselect)
            {
                case 1:
                    Insert();
                    break;
                case 2:
                    Select();
                    break;
                case 3:
                    //Update();
                    break;
                case 4:
                    //Delete();
                    break;
                case 5:
                    //DeleteAll();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("null");
                    Options();
                    break;

            } 
        }


        public void Insert()
        {
            Console.WriteLine("Please enter data ");
            string name = Console.ReadLine();
            Database database = Database.MakeSingleton();
            if (name == PRODUCTABLE)
            {
                Product product = new Product(1, "produc", 1);
                database.InsertTable("produc", product);
                Options();
                return;
            }

            if (name == CATAGORY)
            {
                Category category = new Category(2, "catagory", 2);
                database.InsertTable("catagory", category);
                Options();
                return;
            }

            if (name == ACCESORY)
            {
                Accessotion accessotion = new Accessotion(3, "accesory", 3);
                database.InsertTable("accesory", accessotion);
                Options();
                return;
            }

        }

        public void Select()
        {
            Console.WriteLine("Please enter data ");
            string name = Console.ReadLine();
            Database database = Database.MakeSingleton();
            if (name == PRODUCTABLE)
            {
                Console.WriteLine("Select");
                Product product = new Product(1, "produc", 1);
                database.SelectTable("produc", product);
                Options();
                return;
            }

            if (name == CATAGORY)
            {
                Console.WriteLine("catagory");
                Category category = new Category(1, "catagory", 1);
                database.SelectTable("catagory", category);
                Options();
                return;
            }

            if (name == ACCESORY)
            {
                Console.WriteLine("accesory");
                Accessotion accessotion = new Accessotion(1, "accesory", 1);
                database.SelectTable("accesory", accessotion);
                Options();
                return;
            }
        }


    }

}

