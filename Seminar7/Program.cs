// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


Console.Write("Введите значение m: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int colums = int.Parse(Console.ReadLine());
int[,] array = CreateArray(rows, colums);

int[,] CreateArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)//0
    {
        for (int j = 0; j < n; j++)//0,1
        {
            result[i, j] = i + j;//0 1
        }
    }
    return result;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
