using Tyuiu.KazachekI.Sprint2.Task0.V24.Lib;

DataService ds = new DataService();
int x = 135;
int y = 755;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("***************************************");
Console.WriteLine("* Исходные данные                     *");
Console.WriteLine("***************************************");
Console.WriteLine("x=" + x);
Console.WriteLine("y=" + y);

Console.WriteLine("***************************************");
Console.WriteLine("* Результат                           *");
Console.WriteLine("***************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();