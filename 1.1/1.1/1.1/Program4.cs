using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
namespace _1._1
{
    class Program4
    {
        static void Main(string[] args)
        {
            var sources = Enumerable.Range(100, 20000);
            var parallelQuery = from num in sources.AsParallel()
                                where num % 100 == 0
                                select num;
           
            foreach (var item in parallelQuery)
            {
                Console.WriteLine(item);
            }               
        }   
    }
}
