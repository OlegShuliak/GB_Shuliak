// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод вывода результата
void PrintResult(string msg, long res)
{
    Console.WriteLine(msg + res);
}

// Метод вычисления суммы чисел от 1 от A
long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sum += i; //sum = sum +i
    }
    return sum;
}

// Метод вычисления суммы чисел от 1 от A (Метод Гаусса)
long SumGauss(int numA)
{
    return ((1 + (long)numA) * (long)numA) / 2;
}

int numberA = ReadData("Введите число А: ");
long res1 = SumSimple(numberA);
long res2 = SumGauss(numberA);
PrintResult("Сумма чисел от 1 до А (Простой метод): ", res1);
PrintResult("Сумма чисел от 1 до А (Метод Гаусса): ", res2);


