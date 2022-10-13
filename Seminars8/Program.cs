


int[,] CreateArray(int r, int c)
{
    int[,] Array = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Array[i, j] = new Random().Next(1, 20);
            Console.Write(Array[i, j]+ "\t");
        }
        Console.WriteLine();
    }
    return Array;
}

int[] GoodArray(int[,] matrix, int[] array)
{
    int[] Out = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (array[i] == matrix[y, x])
                {
                    Out[i]++;
                }
            }
        }
    }
    return Out;
}
int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

int[] good = GoodArray(CreateArray(6, 6), array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Число {array[i]} = {good[i]}");
}
