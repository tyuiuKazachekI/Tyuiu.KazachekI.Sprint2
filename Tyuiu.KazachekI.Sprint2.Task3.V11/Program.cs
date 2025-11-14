using Tyuiu.KazachekI.Sprint2.Task3.V11.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Вычисление значения функции Y       *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Функция:                           *");
        Console.WriteLine("* y = x + ((x-15)/(x-19))^x, если x > 0");
        Console.WriteLine("* y = x² - sin(x²) + 12, если x = 0  *");
        Console.WriteLine("* y = (1 + 1/x²)^x, если -15 < x < 0 *");
        Console.WriteLine("* y = x + 10x - 1/x, если x < -15    *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите значение X: ");
            double x = GetDoubleInput();

            double result = ds.Calculate(x);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"При x = {x}");
            Console.WriteLine($"y = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("* Ошибка!                            *");
            Console.WriteLine("***************************************");
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nНажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    static double GetDoubleInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            Console.Write("Ошибка! Введите число: ");
        }
    }
}