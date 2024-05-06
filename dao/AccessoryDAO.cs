using OOP_B1.demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    internal class AccessoryDAO
    {

        private static AccessoryDAO instance;
        public static AccessoryDAO MakeSingleton()
        {
            if (instance == null)
            { instance = new AccessoryDAO(); }
            return instance; ;
        }
        public void Insert(Product product)
        {

        }

        public void Update(Product product)
        {
        }

        public void Delete(int id)
        {

        }
       
    }
}
