
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чило b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.WriteLine("Большее число" + max);
}
else
{
    Console.WriteLine("Большее число" + c);
}
