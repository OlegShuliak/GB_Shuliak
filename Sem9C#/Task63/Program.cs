// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод рекурсии
void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if (numN <= 1)
    {

    }
    else
    {
        LineGenRec(numN - 1);
    }
}

// Вводим данные и выводим результат в консоль
int num = ReadData("Введите число N:");
LineGenRec(num);


