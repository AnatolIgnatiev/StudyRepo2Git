using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    //N (100 ≤ N < 10250) не содержит лидирующих нулей не содержит символов отличных от "0"-"9"
    //максимальное значение, которое может быть получено из N посредством вычеркивания из него ровно двух цифр.
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int n;
            if (int.TryParse(inputString, out n) && !inputString[0].Equals("0"))
            {
                for (int i = 0; i < 2; i++)
                {
                    inputString = inputString.Remove(inputString.IndexOf(inputString.Min()), 1);
                }
            }
            Console.WriteLine(inputString);
        }
    }
}
