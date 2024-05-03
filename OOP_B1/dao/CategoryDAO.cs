using OOP_B1.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    internal class CategoryDAO : Category
    {
        public Database database;

        public bool Insert(object row)
        {
            try
            {
                database.InsertTable("category", row);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
