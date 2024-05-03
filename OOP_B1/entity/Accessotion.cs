using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.entity
{
    internal class Accessotion
    {
        public int id;
        public string name;
        public int categoryId;
        static void Main(string[] args)
        {
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
}
