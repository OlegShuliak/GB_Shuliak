// Необходима посчитать сумму чисел в числе. Использовать рекурсию.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Рекурентный метод
int RecSumDig(int num)
{
    if (num > 0) return num % 10 + RecSumDig(num / 10);
    else return 0;
}

int num = ReadData("Введите любое натуральное число больше 0:");
Console.WriteLine(RecSumDig(num));

