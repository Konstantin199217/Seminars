//каждый четный индекс возводили в квадрат
int rows = 5;
int colums = 5;
int[,] array = CreateArray(rows, colums);

int[,] CreateArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)//0
    {
        for (int j = 0; j < n; j++)//0,1
        {
            result[i, j] = new Random().Next(1, 10);
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
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
for (int i = 1; i < rows; i++)//0
{
    for (int j = 1; j < colums; j++)//0,1
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] *= array[i, j];
        }
    }
}
Console.WriteLine();
PrintArray(array);
