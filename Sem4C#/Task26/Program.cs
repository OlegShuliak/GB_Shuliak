// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод вывода результата
void PrintResult(string msg, int res, string msg1)
{
    Console.WriteLine(msg + res + msg1);
}

// Метод 1
int CountDigit1(long numA)
{
    int res = 0;
    while (numA > 0)
    {
        res = res + 1;
        numA = numA / 10;
    }
    return res;
}


long numberA = ReadData("Введите любое число");
int res1 = CountDigit1(numberA);
PrintResult($"Число {numberA} состоит из ", res1, " цифр");