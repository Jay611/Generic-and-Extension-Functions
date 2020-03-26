using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("The number of words is " + sb.CountWords());
            Console.ReadKey();
        }
    }
}
