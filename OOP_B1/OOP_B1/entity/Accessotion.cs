using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Accessotion : BaseRow
    {
        public Accessotion() { }

        /// <summary>
        /// Initializes a new instance of the Accessory class with the specified ID, name, and category ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryID"></param>
        public Accessotion(int id, string name, int categoryID)
        {
            this.id = id;
            this.name = name;
            this.categoryID = categoryID;
        }

    }
}