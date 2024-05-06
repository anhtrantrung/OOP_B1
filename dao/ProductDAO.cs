using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    internal class ProductDAO
    {
        const string PRODUCTABLE = "produc";
      
        const string ACCESORY = "accesory";
        public static ProductDAO instance;
        public static ProductDAO MakeSingleton()
        {
            if (instance == null)
            { instance = new ProductDAO(); }
            return instance; ;
        }
        public void Insert(Product product)
        {
            Console.WriteLine("ProductDAO " );
            Console.WriteLine("Please enter data ");
            string name = Console.ReadLine();
            Database database = Database.MakeSingleton();
            Console.WriteLine("CheckData");

            if (name == PRODUCTABLE)
            {
                //Product product = new Product(1, "produc", 1);
                database.InsertTable("produc", product);
                Insert(product);
                return;
            }

        }

        public void Update(Product product)
        {
        }

        public void Delete(int id)
        {

        }
        //public List<object> FindAll()
        //{

        //}

        //public object FindById(int id)
        //{

        //}

        //public object FindByName(string name)
        //{

        //}
        public List<object> FindAll()
        {
            Console.WriteLine(("FindAll1"));
            List<object> allData = new List<object>();
            foreach (Product product in Database.MakeSingleton().producTable)
            {
                Console.WriteLine(("FindAll"));
                Console.WriteLine(product.Data());
                allData.Add(product);
             }
            //return (List<object>)(object)Database.GetInstance().productTable;
            return allData;
        }

    }
}
