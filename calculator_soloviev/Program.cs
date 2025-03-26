using System;

namespace calculator_soloviev
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

            try
            {
                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ай-ай-ай: {ex.Message}");
            }
        }

        // Метод для выполнения вычислений
        public static double Calculate(double num1, double num2, char operation)
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Делить на ноль незя"),
                _ => throw new InvalidOperationException("Неверная операция. Выберите одну из списка: +, -, *, /")
            };
        }
    }
}
