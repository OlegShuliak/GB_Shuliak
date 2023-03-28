// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// Вариант 1 (с использованием метода)

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

// Метод принимает две переменные a и b, вызов метода Void
void SqrtTest(int a, int b)
{
    if (a == b * b) Console.WriteLine(a + " является квадратом " + b);
    else Console.WriteLine(a + " не является квадратом " + b);
}

SqrtTest(num1, num2);
SqrtTest(num2, num1);

