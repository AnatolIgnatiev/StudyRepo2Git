using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    //заменяет «1» на «a», «01» на «b», «001» на «c», …, «00000000000000000000000001» на «z»
    //INPUT - строка из символов «0» и «1» длиной не более 255 символов
    //OUTPUT - одна строка из английских строчных букв от «a» до «z» – сжатие заданной бинарной последовательности.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary sequence:");
            string sequence = Console.ReadLine();
            string result = "";
            if (sequence.Length <= 255)
            {
                var splitedSequence = sequence.Split('1');
                for (int i = 0; i < splitedSequence.Length - 1; i++)
                {
                    if (string.IsNullOrEmpty(splitedSequence[i]))
                    {
                        result += "a";
                    }
                    else
                    {
                        result += (char)('a' + splitedSequence[i].Length);
                    }
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Sequence is TOOOOOOOOOO long :)");
            }
            
            Console.ReadLine();
        }
    }
}
