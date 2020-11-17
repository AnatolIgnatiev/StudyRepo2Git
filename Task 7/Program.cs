using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_7
{
    //из двух, трех или четырех английских букв. Первая буква рунного слова всегда записывается как заглавная, а все остальные являются маленькими
    //непустую строку, длиной не более 100000 символов, содержащую только большие и маленькие буквы английского алфавита
    //«Yes», если слово является рунным и «No» в противном случае

    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Regex regex = new Regex("(?<!^)(?=[A-Z])");
            var strings = regex.Split(inputString);
            foreach (var item in strings)
            {
                if (char.IsUpper(item[0]) && item.Length <= 4)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
