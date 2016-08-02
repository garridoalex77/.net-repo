using System;
using System.Collections.Generic;

namespace EmptyConsole1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> allNarns = new List<int>();
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
            char[] wordArr = name.ToCharArray();
            LinkedList<char> revWord = new LinkedList<char>();
            foreach(char letter in wordArr)
            {
                revWord.AddFirst(letter);
            }
            foreach (char letter in revWord)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("hi {0}, here is your name backwards: {1}", name, string.Join("", revWord));
            // Console.WriteLine("hi {0} here is your name backwards {1}", name);
            //Console.WriteLine("[{0}]", string.Join(", ", yourArray));
            // yourArray.ToList().ForEach(Console.WriteLine);
        }
    }
}
