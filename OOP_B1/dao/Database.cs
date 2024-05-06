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
            return instance; ;
        }

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

        public int UpdateTable(string name, BaseRow baseRow)
        {
            if (name == PRODUCTABLE)
            {
                Product product = (Product)Database.MakeSingleton().producTable.FirstOrDefault(productObject => productObject.GetId() == baseRow.GetId());
                if (product != null)
                {
                    product.SetData(baseRow.GetId(), baseRow.GetName(), baseRow.GetCategoryId());
                }
                return 1;
            }

            if (name == CATAGORY)
            {
                Category category = (Category)Database.MakeSingleton().producTable.FirstOrDefault(categoryObject => categoryObject.GetId() == baseRow.GetId());
                if (category != null)
                {
                    category.SetData(baseRow.GetId(), baseRow.GetName(), baseRow.GetCategoryId());
                }
                return 1;
            }

            if (name == ACCESORY)
            {
                Accessotion accessotion = (Accessotion)Database.MakeSingleton().producTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() == baseRow.GetId());
                if (accessotion != null)
                {
                    accessotion.SetData(baseRow.GetId(), baseRow.GetName(), baseRow.GetCategoryId());
                }
                return 1;
            }

            return 0;
        }

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




