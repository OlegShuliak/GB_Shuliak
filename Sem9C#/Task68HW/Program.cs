// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Рекурентный метод функции Аккермана
int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n, m);
}

// Ввод данных
int numN = ReadData("Введите положительное число n: ");
int numM = ReadData("Введите положительное число m: ");

// Вывод результата
Console.WriteLine(Akk(numN, numM));