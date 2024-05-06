using OOP.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.dao
{
    internal interface IDao
    {
        int Insert(BaseRow baseRow);

        int Update(BaseRow baseRow);

        int Delete(BaseRow baseRow, int id);

        int Truncate(BaseRow baseRow);

       


    }
}
