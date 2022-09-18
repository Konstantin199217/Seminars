Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i <= array.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
}
//Цикл for в C# предоставляет механизм итерации, в котором определенное условие проверяется перед выполнением каждой итерации.
// Если число с "-" ? как делать?
