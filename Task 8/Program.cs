using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    //строку длиной 5 символов. Второй символ строки является либо знаком '+' (плюс) либо '-' (минус), четвёртый символ — знак '=' (равно). 
    //Из первого, третьего и пятого символов ровно два являются цифрами из диапазона от 0 до 9, и один — буквой x
    // output x
    
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            if (inputString.Length == 5)
            {
                int firstDigit;
                int secondDigit;
                int result;
                char action = inputString[1];
                switch (action)
                {
                    case '+':
                        {
                            if (!int.TryParse(inputString[0].ToString(), out firstDigit))
                            {
                                int.TryParse(inputString[2].ToString(), out secondDigit);
                                int.TryParse(inputString[4].ToString(), out result);
                                Console.WriteLine(result - secondDigit);
                            }
                            else if (!int.TryParse(inputString[2].ToString(), out secondDigit))
                            {
                                int.TryParse(inputString[4].ToString(), out result);
                                Console.WriteLine(result - firstDigit);
                            }
                            else
                            {
                                Console.WriteLine(firstDigit + secondDigit);
                            }
                        };
                        break;

                    case '-':
                        {
                            if (!int.TryParse(inputString[0].ToString(), out firstDigit))
                            {
                                int.TryParse(inputString[2].ToString(), out secondDigit);
                                int.TryParse(inputString[4].ToString(), out result);
                                Console.WriteLine(result + secondDigit);
                            }
                            else if (!int.TryParse(inputString[2].ToString(), out secondDigit))
                            {
                                int.TryParse(inputString[4].ToString(), out result);
                                Console.WriteLine(firstDigit - result);
                            }
                            else
                            {
                                Console.WriteLine(firstDigit - secondDigit);
                            }
                        };
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
