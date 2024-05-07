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
        /// <summary>
        /// Inserts a new row into the appropriate table in the database.
        /// </summary>
        /// <param name="baseRow"></param>
        /// <returns>Returns 1 if the insert was successful, otherwise returns 0.</returns>
        public int Insert(BaseRow baseRow)
        {
            try
            {
                Database.MakeSingleton().InsertTable(baseRow.GetType().Name, baseRow);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Updates an existing row in the appropriate table in the database.
        /// </summary>
        /// <param name="baseRow"></param>
        /// <returns>Returns 1 if the update was successful, otherwise returns 0.</returns>
        public int Update( BaseRow baseRow)
        {
            try
            {
                Database.MakeSingleton().UpdateTable(baseRow.GetType().Name, baseRow);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Deletes a row from the appropriate table in the database based on the provided ID.
        /// </summary>
        /// <param name="baseRow"></param>
        /// <param name="id"></param>
        /// <returns>True if the delete operation was successful, otherwise false.</returns>
        public bool Delete(BaseRow baseRow, int id)
        {
            try
            {
                Database.MakeSingleton().DeleteTable(baseRow.GetType().Name, id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Removes all rows from the appropriate table in the database.
        /// </summary>
        /// <param name="baseRow"></param>
        public void Truncate(BaseRow baseRow)
        {
            Database.MakeSingleton().TruncateTable(baseRow.GetType().Name);
        }

        /// <summary>
        /// Finds and returns all rows from the appropriate table in the database.
        /// </summary>
        /// <param name="baseRow"></param>
        /// <returns>A list of BaseRow objects representing all rows found in the table.</returns>
        public List<BaseRow> FindAll(BaseRow baseRow)
        {
            return Database.MakeSingleton().SelectTable(baseRow.GetType().Name);
        }
        
    }
}