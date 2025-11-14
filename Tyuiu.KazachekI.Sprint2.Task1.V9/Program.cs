using Tyuiu.KazachekI.Sprint2.Task1.V9.Lib;

DataService ds = new DataService();
int a = 15;
int b = 335;
int c = 174;
int d = 478;
bool[] res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("***************************************");
Console.WriteLine("* Исходные данные                     *");
Console.WriteLine("***************************************");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***************************************");
Console.WriteLine("* Результат                           *");
Console.WriteLine("***************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();