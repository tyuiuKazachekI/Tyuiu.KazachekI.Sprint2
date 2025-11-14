using Tyuiu.KazachekI.Sprint2.Task6.V11.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Определение даты следующего дня     *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Год не является високосным         *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите год (g): ");
            int year = GetIntegerInput();

            Console.Write("Введите месяц (m, 1-12): ");
            int month = GetIntegerInput();

            Console.Write("Введите день (n): ");
            int day = GetIntegerInput();

            string result = ds.FindDateOfNextDay(year, month, day);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"Введенная дата: {day}.{month}.{year}");
            Console.WriteLine($"Следующий день: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine("\nНажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    static int GetIntegerInput()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result) && result > 0)
            {
                return result;
            }
            Console.Write("Ошибка! Введите натуральное число: ");
        }
    }
}