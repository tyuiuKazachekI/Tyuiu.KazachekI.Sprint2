using Tyuiu.KazachekI.Sprint2.Task7.V5.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************");
        Console.WriteLine("* Проверка попадания точки в область  *");
        Console.WriteLine("***************************************");
        Console.WriteLine("* Границы области:                    *");
        Console.WriteLine("* y = e^(-x)  (верхняя граница)       *");
        Console.WriteLine("* y = e^x                             *");
        Console.WriteLine("* y = x²     (нижняя граница)         *");
        Console.WriteLine("* x ≥ 0                               *");
        Console.WriteLine("***************************************");

        try
        {
            Console.Write("Введите координату X: ");
            double x = GetDoubleInput();

            Console.Write("Введите координату Y: ");
            double y = GetDoubleInput();

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************");
            Console.WriteLine("* Результат                           *");
            Console.WriteLine("***************************************");
            Console.WriteLine($"Точка ({x:F2}, {y:F2}) находится в заштрихованной области: {result}");

            if (x >= 0)
            {
                Console.WriteLine($"\nЗначения функций в точке x={x:F2}:");
                Console.WriteLine($"y = e^(-x) = {Math.Exp(-x):F4}  (верхняя граница)");
                Console.WriteLine($"y = e^x    = {Math.Exp(x):F4}");
                Console.WriteLine($"y = x²     = {x * x:F4}  (нижняя граница)");

                if (result)
                {
                    Console.WriteLine($"\nУсловия выполнения:");
                    Console.WriteLine($"y >= x²: {y:F4} >= {x * x:F4} → {y >= x * x}");
                    Console.WriteLine($"y <= e^(-x): {y:F4} <= {Math.Exp(-x):F4} → {y <= Math.Exp(-x)}");
                }
            }
            else
            {
                Console.WriteLine("x < 0 - точка вне области определения");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine("\nНажмите любую клавишу для завершения...");
        Console.ReadKey();
    }

    // Метод для безопасного ввода дробных чисел
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