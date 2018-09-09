using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_Interfaces_Collections
{
    class Programmer : IDeveloper
    {
        private string language;
        public string Tool
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Create Programer");
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy Programer");
        }
    }
}
