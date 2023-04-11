// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

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

//Метод вывода чисел Фибоначчи 
string FibNums(int num)
{
    string res = ("0, 1");
    long first = 0;
    long last = 1;
    for (int i = 2; i <= num; i++)
    {
        res += ", " + (first + last);
        (first, last) = (last, last + first);
    }
    return res;
}

int N = ReadData("Введите количество чисел Фибоначчи");
PrintResult($"Первые {N} чисел Фибоначчи - ", FibNums(N));





