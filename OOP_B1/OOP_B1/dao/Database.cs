using OOP.entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_B1.dao
{
    internal class Database
    {
        private static Database instance;
        private List<BaseRow> producTable = new List<BaseRow>();
        private List<BaseRow> catagoryTable = new List<BaseRow>();
        private List<BaseRow> accesoryTable = new List<BaseRow>();
        const string PRODUCTABLE = "product";
        const string CATAGORY = "catagory";
        const string ACCESORY = "accesory";
        public Database instants;

        public static Database MakeSingleton()
        {
            if (instance == null)
            { instance = new Database(); }
            return instance;
        }

        /// <summary>
        /// Inserts a row into the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        public void InsertTable(string name, BaseRow row)
        {
            if (name == PRODUCTABLE)
            {
                producTable.Add(row);
            }

            if (name == CATAGORY)
            {
                catagoryTable.Add(row);
            }

            if (name == ACCESORY)
            {
                accesoryTable.Add(row);
            }
        }

        /// <summary>
        /// Selects a table based on the provided name.
        /// </summary>
        /// <param name="name"></param>
        /// /// <returns>List</returns>
        public List<BaseRow> SelectTable(string name)
        {
            if (name == PRODUCTABLE)
            {
                return producTable;
            }

            if (name == CATAGORY)
            {
                return catagoryTable;
            }

            if (name == ACCESORY)
            {
                return accesoryTable;
            }

            else
            {
                return null;
            }
        }

        /// <summary>
        /// Updates a row in the specified table.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="baseRow"></param>
        /// <returns>An integer indicating the success of the update operation. Returns 1 if the update was successful, otherwise returns 0.</returns>
        public int UpdateTable(string name, BaseRow baseRow)
        {
            if (name == PRODUCTABLE)
            {
                Product updatedProduct = (Product)baseRow;
                int setIdProduct = updatedProduct.GetId();

                foreach (Product product in producTable)
                {
                    if (product.GetId() == setIdProduct)
                    {
                        product.SetName(updatedProduct.GetName());
                        return 1;
                    }
                }
            }

            if (name == CATAGORY)
            {
                Category updatedCategory = (Category)baseRow;
                int setIdCategory = updatedCategory.GetId();

                foreach (Category category in catagoryTable)
                {
                    if (category.GetId() == setIdCategory)
                    {
                        category.SetName(updatedCategory.GetName());
                        return 1;
                    }
                }
            }

            if (name == ACCESORY)
            {
                Accessotion updatedAccessotion = (Accessotion)baseRow;
                int setIdAccessotion = updatedAccessotion.GetId();

                foreach (Accessotion accessotion in accesoryTable)
                {
                    if (accessotion.GetId() == setIdAccessotion)
                    {
                        accessotion.SetName(updatedAccessotion.GetName());
                        return 1;
                    }
                }
            }

            return 0;
        }

        /// <summary>
        /// Deletes a row from the specified table based on the provided ID.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public void DeleteTable(string name, int id)
        {
            if (name == PRODUCTABLE)
            {
                if (name == PRODUCTABLE)
                {
                    producTable.RemoveAll(productObject => productObject.GetId() == id);
                    return;
                }
            }

            if (name == CATAGORY)
            {

                if (name == CATAGORY)
                {
                    catagoryTable.RemoveAll(productObject => productObject.GetId() == id);
                    return;
                }
            }

            if (name == ACCESORY)
            {
                if (name == ACCESORY)
                {
                    accesoryTable.RemoveAll(productObject => productObject.GetId() == id);
                    return;
                }
            }
        }

        /// <summary>
        /// Removes all rows from the specified table.
        /// </summary>
        /// <param name="name"></param>
        public void TruncateTable(string name)
        {
            if (name == PRODUCTABLE)
            {
                producTable.Clear();
                return;
            }

            if (name == CATAGORY)
            {
                catagoryTable.Clear();
                return;
            }

            if (name == ACCESORY)
            {
                accesoryTable.Clear();
                return;
            }
        }
    }

}




