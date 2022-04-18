using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class calculator
    {


        static void Main(string[] args)
        {
            double num1;
            double num2;
            string operand;
            ConsoleKeyInfo status;
            double answer;

            while (true)
            {
                Console.Write("Enter First Number : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = num1 - num2;
                        break;
                    case "+":
                        answer = num1 + num2;
                        break;
                    case "/":
                        answer = num1 / num2;
                        break;
                    case "*":
                        answer = num1 * num2;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
               
            }
        }

    }
}
