// Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.


//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}


// Вариант 1
// Метод вычисления при помощи цикла
int SummNums1(int A)
{
    int res = 0;
    while (A > 0)
    {
        res += A % 10;
        A = A / 10;
    }
    return res;
}

// Ввод данных и вывод результата с оценкой времени алгоритма*
int numA1 = ReadData("Введите любое число больше 0: ");
DateTime d1 = DateTime.Now;
int result1 = SummNums1(numA1);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Сумма цифр в числе равна: ", result1);

// Вариант 2
// Метод вычисления при помощи цикла и массива
int SummNums2(int A)
{
    int res = 0;
    char[] arrNums = A.ToString().ToArray();
    for (int i = 0; i < arrNums.Length; i++) res += (arrNums[i] - 48);
    return res;
}

// Ввод данных и вывод результата с оценкой времени алгоритма*
int numA2 = ReadData("Введите любое число больше 0: ");
DateTime d2 = DateTime.Now;
int result2 = SummNums2(numA2);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма цифр в числе равна: ", result2);





