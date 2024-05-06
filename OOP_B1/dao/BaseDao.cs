using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP_B1.dao;

namespace OOP.dao
{
    abstract class BaseDao
    {
        public int Insert(BaseRow baseRow)
        {
            try
            {
                Database.MakeSingleton().InsertTable(baseRow.GetName(), baseRow);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Update( BaseRow baseRow)
        {
            try
            {
                Database.MakeSingleton().UpdateTable(baseRow.GetName(), baseRow);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public bool Delete(BaseRow baseRow, int id)
        {
            try
            {
                Database.MakeSingleton().DeleteTable(baseRow.GetName(), id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Truncate(BaseRow obj)
        {
            Database.MakeSingleton().TruncateTable(obj.GetName());
        }

        public List<BaseRow> FindAll(BaseRow obj)
        {
            return Database.MakeSingleton().SelectTable(obj.GetName());
        }
        
    }
}