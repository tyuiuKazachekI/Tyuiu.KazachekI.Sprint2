using Tyuiu.KazachekI.Sprint2.Task2.V8.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Проверка попадания точки в область  *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Координаты: X - горизонтальная,     *");
        Console.WriteLine("*              Y - вертикальная       *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Описание заштрихованной области:    *");
        Console.WriteLine("* x=2: y=9,10,11                      *");
        Console.WriteLine("* x=3,4: y=3,4,5                     *");
        Console.WriteLine("* x=5: y=3-9                         *");
        Console.WriteLine("* x=6: y=3-13                        *");
        Console.WriteLine("* x=7: y=3-14                        *");
        Console.WriteLine("* x=8: y=6,9,12,13                   *");
        Console.WriteLine("* x=9: y=6-9,12,13                   *");
        Console.WriteLine("* x=10: y=6-9                        *");
        Console.WriteLine("* x=11: y=3-9                        *");
        Console.WriteLine("* x=12: y=7-9                        *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите координату X (горизонтальная): ");
            int x = GetIntegerInput();

            Console.Write("Введите координату Y (вертикальная): ");
            int y = GetIntegerInput();

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"Точка (X={x}, Y={y}) находится в заштрихованной области: {result}");

            if (result)
            {
                Console.WriteLine("✓ Точка находится ВНУТРИ заштрихованной области");
            }
            else
            {
                Console.WriteLine("✗ Точка находится ВНЕ заштрихованной области");
            }
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