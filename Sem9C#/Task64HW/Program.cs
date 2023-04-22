// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод рекурсии вывода чисел от N до 1
void LineGenRecToMin(int numN)
{
    Console.Write(numN + " ");
    if (numN <= 1)
    {

    }
    else
    {
        LineGenRecToMin(numN - 1);
    }
}

// Метод рекурсии вывода чисел от 1 до N 
string LineGenRecToMax(int numN)
{
    if (numN < 1)
    {
        return string.Empty;
    }
    else
    {
        return LineGenRecToMax(numN - 1) + "" + numN + " ";
    }
}

// Вводим данные и выводим результат в консоль
int num = ReadData("Введите число N:");
LineGenRecToMin(num);
Console.WriteLine();
Console.WriteLine(LineGenRecToMax(num));



