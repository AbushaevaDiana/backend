using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endOfProgram = false;
            while (!endOfProgram)
            {
                endOfProgram = true;
                Console.Write("Введите первое число:                         ");
                double first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите действие над числами(+, -, *, /):     ");
                string? action = Console.ReadLine();
                Console.Write("Введите второе число:                         ");
                double second_number = Convert.ToInt32(Console.ReadLine());
                
                double result = double.NaN;

                switch (action)
                {
                    case "+":
                        result = first_number + second_number;
                        break;
                    case "-":
                        result = first_number - second_number;
                        break;
                    case "*":
                        result = first_number * second_number;
                        break;
                    case "/":
                        result = first_number / second_number;
                        break;
                    default:
                        break;
                }

                Console.Write("Результат:                                    ");
                Console.WriteLine(result);
                Console.Write("Введите y или Y, если хотите продолжить:      ");
                string? str = Console.ReadLine();
                if (str == "y" || str == "Y")
                {
                    endOfProgram = false;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Спасибо за работу. До свидания.");

        }
    }
}
