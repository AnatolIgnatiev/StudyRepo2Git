using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        //Yужно определить, какие из номеров соответствуют принятому стандарту, а какие нет.
        //Первая строка входного файла INPUT.TXT содержит единственное натуральное число N – количество записанных Васей номеров (N ≤ 50). 
        //Далее следует N строк с записями номеров автобусов.
        //Длины строк от 1 до 300 и содержат только символы с кодами ASCII от 33 до 127 (не содержат пробелов, специальных и русских символов).

        //состоит из 6 символов: трех букв и трех цифр. 
        //Сначала буква, затем 3 цифры и еще 2 буквы. Kюбые цифры от 0 до 9, буквы: A, B, C, E, H, K, M, O, P, T, X, Y. 
        //Например, «P204BT» - правильный номер, а «X182YZ» и «ABC216» - нет.
        private static int GetNumberOfPlates(out int result)
        {
            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input symbol");
            }
            else if (result >= 50)
            {
                Console.WriteLine("Invalid number of plates");
            }
            return result;
        }
        private static bool PlateFormatIsCorrect(string plate)
        {
            Regex regex = new Regex("^[ABCEHKMOPTXY][0-9]{3}[ABCEHKMOPTXY]{2}");
            
            return regex.IsMatch(plate);
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write($"Enter number of plates:");
            GetNumberOfPlates(out n);

            List<string> results = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string curentPlate;
                Console.WriteLine($"Enter {i} plate symbols:");
                curentPlate = Console.ReadLine();
                if (PlateFormatIsCorrect(curentPlate))
                {
                    results.Add("Yes");
                }
                else
                {
                    results.Add("No");
                }
            }
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
