//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А. 

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SumDigitOneToA(int numA)
{
    int sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum + i;
        //sum+=i;
    }
    return sum;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int GausMethod(int numA)
{
    int sum = ((1 + numA) * numA) / 2;
    return sum;
}

int numA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int sum = SumDigitOneToA(numA);
Console.WriteLine(DateTime.Now - d1);

PrintData("Сумма чисел от 1 до А ", sum);

DateTime d2 = DateTime.Now;
int sumGaus = GausMethod(numA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А Gaus ", sum);
