//Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе. 

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int CountDigitNum(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int CountDigitLog(int num)
{
    int digitcount = (int)Math.Log10(num)+1;
    return digitcount;
}
int CountDigitString(int num)
{
    return num.ToString().Length;
}

int num = ReadData("Ввидите число А:  ");
PrintData("Колличество цифр в числе " + num + " равно ", CountDigitLog(num));
PrintData("Колличество цифр в числе " + num + " равно ", CountDigitNum(num));
PrintData("Колличество цифр в числе " + num + " равно ", CountDigitString(num));


