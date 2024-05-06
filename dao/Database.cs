using OOP_B1.entity;
using System;
using System.Collections.Generic;

namespace OOP_B1.dao
{
    internal class Database
    {
        private static Database instance;
        public List<object> producTable = new List<object>();
        public List<object> catagoryTable = new List<object>();
        public List<object> accesoryTable = new List<object>();
        const string PRODUCTABLE = "produc";
        const string CATAGORY = "catagory";
        const string ACCESORY = "accesory";
        public Database instants;
        public Product product;
        public Category category;
        public Accessotion accession;
        public static Database MakeSingleton()
        {
            if (instance == null)
            { instance = new Database(); }
            return instance; ;
        }

        public void InsertTable(string name, object row)
        {
            if (name == PRODUCTABLE)
            {
                producTable.Add(row);
                Product product = (Product)row;
                Console.WriteLine(product.Data()); 
                //Console.WriteLine(producTable);
            }

            if (name == CATAGORY)
            {
                catagoryTable.Add(row);
                Category category = (Category)row;
                Console.WriteLine(category.Data()); 
                //Console.WriteLine(producTable);
            }

            if (name == ACCESORY)
            {
                accesoryTable.Add(row);
                Accessotion accessotion = (Accessotion)row;
                Console.WriteLine(accessotion.Data());
                //Console.WriteLine(producTable);
            }
        }

        public List<object> SelectTable(string name, object where)
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

        public void UpdateTable(string name, object row)
        {
            if (name == PRODUCTABLE)
            {
                foreach (int count in producTable)
                {
                    if (count == product.GetId())
                    {
                        producTable.Add(row);
                        return;
                    }
                }
            }

            if (name == CATAGORY)
            {
                foreach (int count in producTable)
                {
                    if (count == category.GetId())
                    {
                        catagoryTable.Add(row);
                        return;
                    }
                }
            }

            if (name == ACCESORY)
            {
                foreach (int count in producTable)
                {
                    if (count == accession.GetId())
                    {
                        accesoryTable.Add(row);
                        return;
                    }
                }
            }
        }

        public void DeleteTable(string name, object row)
        {
            if (name == PRODUCTABLE)
            {
                foreach (var obj in producTable)
                {
                    if (obj == row)
                    {
                        producTable.Remove(obj);
                        return;
                    }
                }
            }

            if (name == CATAGORY)
            {
                foreach (var obj in catagoryTable)
                {
                    if (obj == row)
                    {
                        catagoryTable.Remove(obj);
                        return;
                    }
                }
            }

            if (name == ACCESORY)
            {
                foreach (var obj in accesoryTable)
                {
                    if (obj == row)
                    {
                        accesoryTable.Remove(obj);
                        return;
                    }
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

        public void UpdateTableById(int id, object row)
        {

        }
    }



}
