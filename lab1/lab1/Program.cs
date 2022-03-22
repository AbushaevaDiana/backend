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
                double firstNumber;
                double secondNumber;
                Console.Write("Введите первое число:                         ");
                firstNum:
                try
                {
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! вы ввели не число\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите первое число:                         ");
                    goto firstNum;
                }
                Console.Write("Введите действие над числами(+, -, *, /):     ");
                string? action = Console.ReadLine();
                Console.Write("Введите второе число:                         ");
                secondNum:
                try
                {
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! вы ввели не число\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите второе число:                         ");
                    goto secondNum;
                }

                double result = double.NaN;

                switch (action)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неизвестный оператор.");
                        break;
                }

                Console.Write("Результат:                                    ");
                Console.WriteLine(result);

                Console.ForegroundColor = ConsoleColor.White;
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
