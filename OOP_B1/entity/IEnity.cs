using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_B1.entity
{
    internal interface IEnity
    {
        int GetId();

        void SetId(int id);

        string GetName();

        void SetName(string name);

        int GetCategoryId();

        void SetCategoryId(int categoryId);

        string GetData();

        void SetData(int categoryId);


    }
}
