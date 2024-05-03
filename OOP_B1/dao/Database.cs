using OOP_B1.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_B1.dao
{
    internal class Database
    {
        private static Database instance;
        public List<object> producTable = new List<object>();
        public List<object> catagoryTable = new List<object>();
        public List<object> accesoryTable = new List<object>();
        const string produc = "PRODUCTABLE";
        const string catagory = "CATAGORY";
        const string accesory = "ACCESORY";
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
            if (name == produc)
            {
                producTable.Add(row);
            }

            if (name == catagory)
            {
                catagoryTable.Add(row);
            }

            if (name == accesory)
            {
                accesoryTable.Add(row);
            }
        }

        public List<object> SelectTable(string name, object where)
        {
            if (name == produc)
            {
                return producTable;
            }

            if (name == catagory)
            {
                return catagoryTable;
            }

            if (name == accesory)
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
            if (name == produc)
            {
                foreach (int count in producTable)
                {
                    if(count == product.GetId())
                    {
                        producTable.Add(row);
                        return;
                    }    
                }
            }

            if (name == catagory)
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

            if (name == accesory)
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
            if (name == produc)
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

            if (name == catagory)
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

            if (name == accesory)
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
            if (name == produc)
            {
                producTable.Clear();
                return;
            }

            if (name == catagory)
            {
                catagoryTable.Clear();
                return;
            }

            if (name == accesory)
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
