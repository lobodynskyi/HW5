using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_Interfaces_Collections
{
    interface IDeveloper
    {
        string Tool
        {
            get;
            set;
        }
        void Create();
        void Destroy();
    }
}
