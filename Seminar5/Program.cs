/// /////Вноси введенные слова в массив
// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(" ");//указывать в ковычках разделительный знак
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
// }
/// ///тоже что и выше только с выбором рандомного слова
// string words = Console.ReadLine();
// Console.WriteLine(words);
// string[] nums = words.Split(",");
// int index = new Random().Next(0,nums.Length);
// Console.WriteLine(nums[index]);

//Замена элиментов

// int[] CreatorArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// int[] NumberArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]*=-1;
//     }
//     return array;
// }
// int[]array = CreatorArray(8, -10,11);
// Console.WriteLine(String.Join(" ", array));
// array = NumberArray(array);
// Console.WriteLine(String.Join(" ", array));


///////Поиск числа в массиве
// bool FintNumber(int number, int[] array)
// {
//     bool flag = false;
//     foreach (var item in array)
//     {
//         if(item==number)
//         {
//             flag = true;
//             return true;
//         }
//     }
//     return false;
// }

// int[]array = CreatorArray(8, -10,11);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine(FintNumber(1,array));


int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
int[] NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
bool FintNumber(int number, int[] array)
{
    return array.Contains(number);
}

int[] array = CreatorArray(8, -10, 11);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(FintNumber(1, array));


