using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.entity
{
    abstract class BaseRow
    {
        protected int id;
        protected string name;

        protected virtual int GetId()
        {
            return this.id;
        }

        protected virtual void SetId(int id)
        {
            this.id = id;
        }

        protected virtual string GetName()
        {
            return this.name;
        }

        protected virtual void SetName(string name)
        {
            this.name = name;
        }

        protected virtual string TxtData()
        {
            return "Id:" + this.id + " - Name:" + this.name;
        }
    }
}

