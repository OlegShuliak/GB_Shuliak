// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics; // Позволяет использовать переменные BigInteger

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод вывода результата
void PrintResult(string msg, BigInteger res)
{
    Console.WriteLine(msg + res);
}

// Метод нахождения факториала числа N
BigInteger Factor(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i; // res = res * i
    }
    return res;
}


int numberA = ReadData("Введите любое число");
PrintResult($"Факториал числа {numberA} = ", Factor(numberA));
