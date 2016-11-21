﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parallel_proces_tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ParallelObject> listParallels = new List<ParallelObject>();
            listParallels.Add(new ParallelObject(1));
            listParallels.Add(new ParallelObject(2));
            listParallels.Add(new ParallelObject(3));
            Parallel.ForEach(listParallels, (curParallels) => curParallels.Print());
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();
        }
    }
}
