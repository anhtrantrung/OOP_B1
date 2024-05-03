using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    internal class Database
    {
        public List<object> producTable = new List<object>();
        public List<object> catagoryTable = new List<object>();
        public List<object> accesoryTable = new List<object>();
        public string produc = " producTable ";
        public string catagory = "catagory";
        public string accesory = "accesory";



        public Database instants;

       

        public void insertTable(string name, object row)
        {
            if (name == produc )
            {
                producTable.Add(row);
            }
            if (name == catagory)
            {
                catagoryTable.Add(row);
            }
            if (name == accesory)
            {
                accesoryTable.Add(row);
            }

            

        }
        public List<object> selectTable(string name, object where)
        {
            if (name == produc)
            {
               
            }

            return catagoryTable;
        }
        public List<object> updateTable(string name, object row)
        {
            if (row == produc)
            {

            }

            return catagoryTable;
        }
    }



}
