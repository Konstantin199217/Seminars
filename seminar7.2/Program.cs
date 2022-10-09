//сумма по диаганали

int rows = 5;
int colums = 5;
int len = rows>colums ? rows : colums;


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
int sum = 0;
for (int i = 0; i < len; i++)//0
{ 
    sum += array [i,i];
}
Console.WriteLine();
PrintArray(array);


