using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BasicCalcConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display instructions
            WriteLine("Please type in your basic calculation in this format\n\n\tEx. 2 + 2 =\n\nWe accept + - * / with 2 numbers only!\n\n");

            string[] equation = new string[4];

            string userInput = ReadLine();

            equation = userInput.Split();

            double
                num1 = double.Parse(equation[0]),
                num2 = double. Parse(equation[2]),
                answer = 0;

            switch(equation[1])
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;
            }

            //Display the answer
            WriteLine($"\n---Answer Calculated---\n\n{answer:N2}");

            //Halt program for user to read answer
            ReadKey();

        }
    }
}
