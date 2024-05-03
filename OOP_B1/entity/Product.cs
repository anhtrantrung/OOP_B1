using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1
{
    internal class Product
    {
        public int id;
        public string name;
        public int categoryId;
     
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetcategoryId()
        {
            return categoryId;
        }
        public void SetcategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

    }

}

