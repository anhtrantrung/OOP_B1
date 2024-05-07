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

        /// <summary>
        /// Initializes a new instance of the Product class with the specified ID, name, and category ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

    }
}