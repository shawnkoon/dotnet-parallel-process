using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parallel_proces_tester
{
    public class ParallelObject
    {
        private int ID;

        public ParallelObject(int ID)
        {
            this.ID = ID;
        }

        public void Print()
        {
            for(int i = 0; i < 100; i++)
                Console.WriteLine("I am obj ID=" + this.ID + " i="+i);
        }
    }
}
