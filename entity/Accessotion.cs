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

        public Accessotion(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public string Data()
        {
            return "id:"+ id+" name:"+name+" categoryId:"+categoryId;

        }

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

