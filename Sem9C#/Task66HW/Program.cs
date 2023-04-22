// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Рекурентный метод решения
int RecSumMN(int m, int n)
{
    if (m < n) 
    {
        return m + RecSumMN(m + 1, n);
    }
    else return m;
}

// Ввод данных
int numM = ReadData("Введите число m: ");
int numN = ReadData("Введите число n: ");

// Вывод с защитой от "дурака", используем тернарный оператор
Console.WriteLine(RecSumMN((numM > numN) ? numN : numM, (numM > numN) ? numM : numN));












