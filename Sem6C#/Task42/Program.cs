// Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод вывода результата
void PrintResult(string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод преобразования десятичного числа в двоичное
string DecToBin(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num = num / 2;
    }
    return res;
}

int number = ReadData("Введите любое число больше 0:");
PrintResult("В двоичном варианте число равно - ", DecToBin(number));














