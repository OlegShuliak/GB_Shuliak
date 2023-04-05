// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

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

// Вариант 1
// Метод возведения числа А в степень В
BigInteger Pow(int A, int B)
{
    BigInteger res = A;
    for (int i = 1; i < B; i++) res *= A;
    return res;
}

// Ввод данных и вывод результата
int numA = ReadData("Введите число, которое нужно возвести в стпень: ");
int numB = ReadData("Введите степень, в которую нужно возвести число: ");
PrintResult($"{numA} в степени {numB} равно ", Pow(numA, numB));

// Вариант 2* - Написать калькулятор с операциями +, -, /, * и возведение в степень
// Метод использования различных метематических операторов
BigInteger Calc(int A, int B, string C)
{
    BigInteger res = 0;
    if (C == "+") res = A + B;
    if (C == "-") res = A - B;
    if (C == "*") res = A * B;
    if (C == "/") res = A / B;
    if (C == "^") res = (int)Math.Pow(A, B);
    return res;
}

// Ввод чисел
int nummerA = ReadData("Введите число А: ");
int nummberB = ReadData("Введите число В: ");
// Ввод математического оператора
Console.WriteLine("Введите математический оператор (+, -, *, /, ^) ");
string operС = Console.ReadLine() ?? "0";
// Вывод результата
PrintResult("Результат вычислений равен: ", Calc(nummerA, nummberB, operС));