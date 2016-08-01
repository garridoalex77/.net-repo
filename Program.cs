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
            int x = 42;
            switch (x)
            {
                case 42:
                case 33:
                    Console.WriteLine("Its 42");
                    Console.WriteLine("is it 33");
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }
        }
    }
}
