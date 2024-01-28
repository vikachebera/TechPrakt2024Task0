using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double firstNumber))
        {
            Console.Write("Введіть друге число: ");
            input = Console.ReadLine();

            if (double.TryParse(input, out double secondNumber))
            {
                double sum = firstNumber + secondNumber;

                Console.WriteLine($"Сума чисел {firstNumber} + {secondNumber} = {sum}");
            }
            else
            {
                Console.WriteLine("Некоректне введення для другого числа.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне введення для першого числа.");
        }
    }
}
