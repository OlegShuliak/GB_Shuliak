// Напишите программу, которая будет принимать два числа a и b,
// возведите число a в степень b с помощью рекурсии.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод рекурсии, вариант 1
long RecPowFirst(int a, int b)
{
    if (b > 0) return a * RecPowFirst(a, b - 1);
    else return 1;
}

// Метод рекурсии, вариант 2
long RecPowSecond(int a, int b)
{
    if (b == 2) return 4;
    else return RecPowSecond(a, b / 2) * RecPowSecond(a, b / 2);
}

// Вводим данные и выводими результат с проверкой быстродействия методов
int numA = ReadData("Введите число a:");
int numB = ReadData("Введите число b:");

DateTime d1 = DateTime.Now;
Console.WriteLine(RecPowFirst(numA, numB));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
Console.WriteLine(RecPowSecond(numA, numB));
Console.WriteLine(DateTime.Now - d2);