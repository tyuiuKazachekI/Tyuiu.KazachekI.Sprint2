using Tyuiu.KazachekI.Sprint2.Task4.V16.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Вычисление значения функции Z       *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Условие:                           *");
        Console.WriteLine("* Если 2x < 2y, то z = (1 + 1/y²)^x  *");
        Console.WriteLine("* Иначе z = y - 1/x²                 *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите значение X: ");
            double x = GetDoubleInput();

            Console.Write("Введите значение Y: ");
            double y = GetDoubleInput();

            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"При x = {x}, y = {y}");
            Console.WriteLine($"2x = {2 * x}, 2y = {2 * y}");
            Console.WriteLine($"Условие 2x < 2y: {2 * x < 2 * y}");
            Console.WriteLine($"z = {result}");
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