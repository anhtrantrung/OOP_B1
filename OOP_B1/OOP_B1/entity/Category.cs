using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Category : BaseRow
    {
        public Category() { }

        /// <summary>
        /// Initializes a new instance of the Category class with the specified ID, name, and parent category ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryID"></param>
        public Category(int id, string name, int categoryID)
        {
            this.id = id;
            this.name = name;
            this.categoryID = categoryID;
        }
    }
}