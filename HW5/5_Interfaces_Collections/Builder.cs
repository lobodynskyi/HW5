using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_Interfaces_Collections
{
    class Builder : IDeveloper
    {
        private string tool;
        public string Tool
        {
            get
            {
                return tool;
            }
            set
            {
                tool = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Create Builder");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy Builder");
        }
    }
}
