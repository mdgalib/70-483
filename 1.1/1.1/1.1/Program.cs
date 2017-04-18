using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1._1
{
    class Program
    {
        public static void ThreadMethod() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThredProc {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread do some work");
                Thread.Sleep(0);
            }
            t.Join();
            Console.WriteLine("branch feature1 a little change");
        }

    }
}
