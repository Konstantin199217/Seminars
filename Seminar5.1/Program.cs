//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}

int[] Array = CreateArray(123);
Console.WriteLine(String.Join(",", Array));
Console.WriteLine();
int[] ArrayRange = Array[10..99];
int totalElements = ArrayRange.Count();
foreach (var item in ArrayRange)
{
    Console.WriteLine(String.Join(",", item));
}
Console.WriteLine();
Console.WriteLine(totalElements);

