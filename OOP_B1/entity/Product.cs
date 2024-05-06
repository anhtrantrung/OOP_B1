using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Product : BaseRow
    {
        private int categoryId;

        public Product() { }

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

    }
}