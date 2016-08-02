using System;
using System.Collections.Generic;

namespace EmptyConsole1
{
    public class Program
    {
        public static void Main(string[] args)
        {
    //         List<int> allNarns = new List<int>();
    //         int num = 0;
    //         int numArrLength = 0;
    //         int i;
    //         do
    //         {
    //             double check = 0;
    //             int numLength = num.ToString().Length;
    //             i = 0;
    //             do
    //             {
    //                 char[] numArr = num.ToString().ToCharArray();
    //                 numArrLength = numArr.Length;
    //                 check += Math.Pow(Int32.Parse(numArr[i].ToString()), numLength);
    //                 i++;
                    
    //                 if (check > num) {
    //                     break;
    //                 }
    //             } while (i < numLength);
    //             if (num == check) {
    //                 allNarns.Add(num);
    //                 Console.WriteLine(num);
    //             }
    //             num++;
    //         } while (allNarns.ToArray().Length < 25);

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("hi {0}", name);
            char[] wordArr = name.ToCharArray();
            Console.WriteLine("{0}", wordArr);
        }
    }
}
