using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3
{
    //только из символов ‘>’, ‘<’ и ‘-‘
    //найти количество стрел
    //Стрелы – это
    //‘>>-->’ и ‘<--<<’
    //"<<<<>>--><--<<--<<>>>--><<<<<" - 4
    //"<<<<>>--><--<<--<<>>-->>>--><<<<<" - 5
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter :");
            string inputString = Console.ReadLine();
            Regex regex = new Regex("[^><-]");
            if (regex.IsMatch(inputString))
            {
                Console.WriteLine("Invalid input chars");
                Console.ReadLine();
                return;
            }
            int counter = 0;
            for (int i = 0; i < inputString.Length - 4; i++)
            {
                var substringTocheck = inputString.Substring(i,5);
                if (substringTocheck.Equals(">>-->") || substringTocheck.Equals("<--<<"))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
