using System;

namespace сalculator_soloviev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дратути");
            Console.WriteLine("Выберите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Выберите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Ай-ай-ай. На ноль делить незя.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неправильная операция. Выберите одну из списка: +, -, *, /");
                    return;
            }

            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }
}
