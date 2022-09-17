

// int number = 12;
// string name = "String - это строка";
// float x = 5.1F; // дроби f ставится обязательно

// bool flag = true; // ложное или правда
// double b = 34.54;
// char type = 'b'; // может содержать только одну цифру или букву

// var r = "asdfd"; //позваляет хранить все но занимает много памяти

// int number = 12;
// System.Console.WriteLine("Месяцев в году" + number.ToString() + number);
// Console.WriteLine("Введите ваше имя");
// string name = Console.ReadLine();// отдает все только строкой
// Console.WriteLine("Привет, " + name);
// Console.WriteLine("Сколько вам лет?");
// int age = int.Parse(Console.ReadLine());// нужен int.Parse чтобы он не выдавал ошибку
// Console.WriteLine("Вам " + age + "лет");

// Console.WriteLine("Введите число а");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine(a+ b);


// if(a > b)
// {
//     Console.WriteLine("Число а больше числа b");
// }
// else if(a < b)
// {
//     Console.WriteLine(" Число b  больше а");
// }else
// {
//     Console.WriteLine(" Число а = b");
// }


//while цикл

Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1, 11);
int attempt = 3;
bool Win = false;
while (attempt > 0)
{
    Console.WriteLine("Введите чило от1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    if (user_number > secret_number)
    {
        Console.WriteLine("Секретное чило меньше");
        attempt--;
    }
    else if (user_number < secret_number)
    {
        Console.WriteLine(" Секретное число больше");
        attempt--;

    }
    else if (user_number == secret_number)
    {
        Console.WriteLine("Угадал");
        Win = true;
        break;
    }
    Console.WriteLine(" Попыток осталось" + attempt);
}
if (Win)
{
    Console.WriteLine(" Вы победили. Поздравляю");
    Console.WriteLine("Осталось попыток " + (attempt - 1));
}
else
{
    Console.WriteLine("Вы проиграли, секретное чило было" + secret_number);
    Console.WriteLine("Попробуй еще");
}
