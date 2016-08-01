using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyConsole1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 8;
            int b = ++a;
            if (a > 5)
                b -= 3;
            else 
                b = 9;
            Console.WriteLine(b);
        }
    }
}
