using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Plane : IFlyable
    {
        string mark;
        int highFly;
        private string v1;
        private int v2;

        public Plane(string v1, int v2)
        {
            this.mark = v1;
            this.highFly = v2;
        }

        public void Fly()
        {
            Console.WriteLine(" - " + mark + "  -  " + highFly);
        }
    }
}
