using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace parallel_proces_tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
        
            List<ParallelObject> listParallels = new List<ParallelObject>();
            listParallels.Add(new ParallelObject(1));
            listParallels.Add(new ParallelObject(2));
            listParallels.Add(new ParallelObject(3));
            Parallel.ForEach(listParallels, (curParallels) => curParallels.Print());
            Console.Write("\nPress any key to continue... ");
            Console.ReadKey();

            
            // Using a named method.
            Parallel.For(0, N, Method2);

            // Using an anonymous method.
            Parallel.For(0, N, delegate (int i)
            {
                // Do Work.
            });

            // Using a lambda expression.
            Parallel.For(0, N, i =>
            {
                // Do Work.
            });
            */

            // src : https://stephenhaunts.com/2014/10/10/simple-async-await-example-for-asynchronous-programming/ 
            var demo = new AsynchAwaitDemo();
            demo.DoStuff();

            while(true)
            {
                Console.WriteLine("This is an infinite loop doing printing!!...........");
                Thread.Sleep(100);
            }
        }

        public class AsynchAwaitDemo
        {
            public async Task DoStuff()
            {
                // await keyword makes it so that it runs asynchronously.
                await Task.Run(() =>
                {
                    LongRunningOperation();
                });


                // this will force the LongRunningOperaion() to finish before going into that loop in main.
                //LongRunningOperation();


            } 

            public async Task<string> LongRunningOperation()
            {
                int counter;

                for(counter = 0; counter <= 50000; counter++)
                {
                    Console.WriteLine(counter);
                    Thread.Sleep(10);
                }

                return "Counter = " + counter;
            }
        }

        public static void Method2(int i)
        {
            // Do Work.
        }
    }
}
