using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5.HW4
{
    class MyColl
    {
        const int StartSizeList = 10;
        ArrayList myColl ; 
        public MyColl()
        {
            myColl = new ArrayList();
            myColl.Add(1);
            myColl.Add(25);
            myColl.Add(3);
            myColl.Add(10);
            myColl.Add(10);
            myColl.Add(1);
            myColl.Add(25);
            myColl.Add(3);
            myColl.Add(10);
            myColl.Add(10);
            FindIndexNumber10();
            RemoveGraterThan20();
            Insert3elements();
            // FillList();
        }

        public void FillList()
        {
            for( int i = 0; i < StartSizeList; i++)
            {
                myColl.Add( Int32.Parse(Console.ReadLine()));
            }
        }

        public void FindIndexNumber10()
        {
            for(int i = 0; i < myColl.Count; i++)
            {
                if ((int)myColl[i] == 10)
                    Console.WriteLine(i);
            }
        }

        public void RemoveGraterThan20()
        {
            for (int i = 0; i < myColl.Count; i++)
            {
                if ((int)myColl[i] > 20)
                    myColl.RemoveAt(i);
            }
        }

        public void Insert3elements()
        {
            Console.WriteLine(myColl);
            myColl.Insert(1,2);
            myColl.Insert(8,-3);
            myColl.Insert(5,-4);
            Console.WriteLine(myColl);
        }
        public void SortElements()
        {
            Console.WriteLine(myColl);
            myColl.Sort();
            Console.WriteLine(myColl);
        }
    }
}
