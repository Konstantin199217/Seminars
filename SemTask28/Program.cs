// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintData(string msg, long value)
{
    Console.WriteLine(msg + value);
}

long Factorial(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res*i;
    }
    return res;
}
int numN = ReadData("Введите число N: ");
long cutResult = Factorial(numN);
PrintData("Факториал числа "+numN+ "равен", cutResult);

