// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

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

// Метод проверки, может ли существовать треугольник с со сторонами a, b, c
bool TrianTest(int a, int b, int c)
{
    bool res = false;
    if (a <= b + c && b <= a + c && c <= a + b)
    {
        return true;
    }
    return res;
}

int a = ReadData("Введите величину первой стороны треугольника:");
int b = ReadData("Введите величину второй стороны треугольника:");
int c = ReadData("Введите величину третьей стороны треугольника:");

string result = string.Empty;
if (TrianTest(a, b, c)) result += "существует";
else result += "не существует";

PrintResult("Треугольник ", result);