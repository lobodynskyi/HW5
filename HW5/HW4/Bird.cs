using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Bird : IFlyable
    {
        string name;
        bool canFly;
        private string v1;
        private int v2;

        public Bird(string v1, bool v2)
        {
            this.name = v1;
            this.canFly = v2;
        }

        public void Fly()
        {
            Console.WriteLine(" - " + name + "  -  " + canFly);
        }
    }
}
