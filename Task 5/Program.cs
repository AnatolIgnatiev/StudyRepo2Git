using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_5
{
    //nA, n — количество повторений символа (целое число от 2 до 99), 
    //а A — заглавная английская буква, либо конструкции вида A, от 1 до 80 символов.
    //трока должна быть разбита на строчки длиной ровно по 40 символов (за исключением последней, которая может содержать меньше 40 символов).
    //	3A4B7D
    // 22D7AC18FGD
    
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            string result = "";
            string numberOfRepeats = "";
            Regex regex = new Regex("[1-99]");
            for (int i = 0; i < inputString.Length; i++)
            {
                if (regex.IsMatch(inputString[i].ToString()))
                {
                    numberOfRepeats += inputString[i];
                }
                else if (!string.IsNullOrEmpty(numberOfRepeats))
                {
                    for (int n = 0; n <= int.Parse(numberOfRepeats) -1; n++)
                    {
                        result += inputString[i];
                    }
                    numberOfRepeats = "";
                }
                else
                {
                    result += inputString[i];
                }
            }
            var iterator = 0;
            foreach (var item in result)
            {
                if (iterator <= 40)
                {
                    Console.Write(item);
                    iterator++;
                }
                else
                {
                    Console.WriteLine(item);
                    iterator = 0;
                }
            }
        }
    }
}
