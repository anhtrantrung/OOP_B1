using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    abstract class BaseRow
    {
        protected int id;
        protected string name;
        protected int categoryID;

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetCategoryId()
        {
            return this.categoryID;
        }

        public virtual void SetCategoryId(int categoryID)
        {
            this.categoryID = categoryID;
        }

        public virtual string GetData()
        {
            return "Id:" + this.id + " - Name:" + this.name + " - categoryID:" + this.categoryID;
        }

        public virtual void SetData(int id, string name, int categoryID)
        {
            this.id = id;
            this.name = name;
            this.categoryID = categoryID;
        }
    }
}