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
        public static void Main(string[] args)
        {
            string result = GetData().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.morphisinc.com");
                return result;
            }
        }
    }
}
