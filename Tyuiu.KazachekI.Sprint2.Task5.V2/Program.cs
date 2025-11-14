using Tyuiu.KazachekI.Sprint2.Task5.V2.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Определение времени года по месяцу  *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Месяца:                            *");
        Console.WriteLine("* 1-Январь, 2-Февраль, 3-Март        *");
        Console.WriteLine("* 4-Апрель, 5-Май, 6-Июнь            *");
        Console.WriteLine("* 7-Июль, 8-Август, 9-Сентябрь       *");
        Console.WriteLine("* 10-Октябрь, 11-Ноябрь, 12-Декабрь  *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = GetIntegerInput();

            string result = ds.FindMonthSeason(month);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"Месяц №{month}: {result}");
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
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.Write("Ошибка! Введите целое число: ");
        }
    }
}