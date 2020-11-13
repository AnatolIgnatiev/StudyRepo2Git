using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    //1 ≤ N ≤ 101000
    // out result & iterations
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:");
            string inputString = Console.ReadLine();
            string temp = inputString;
            int number;
            int counter = 0;
            if (int.TryParse(inputString, out number) && number >= 1 && number <= Math.Pow(10,1000))
            {
                while (number > 10)
                {
                    counter++;
                    var chars = temp.ToCharArray();
                    number = 0;
                    foreach (var item in chars)
                    {
                        number += int.Parse(item.ToString());
                    }
                    temp = number.ToString();
                }
            }
            Console.WriteLine($"{number}  {counter}");
            Console.ReadLine();
        }
    }
}
