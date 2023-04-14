// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions; // Позволяет использовать регулярные выражения

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Вариант 1
// Метод подсчета чисел больше 0
int CountPosNums(int num)
{
    int count = 0;
    while (num > 0)
    {
        int val = ReadData("Введите любое число");
        if (val > 0) count++;
        num--;
    }
    return count;
}

// Ввод данных и вывод результата
int qntyNums = ReadData("Сколько чисел вы хотите ввести?");
Console.WriteLine($"Количество введенных положительных чисел: {CountPosNums(qntyNums)}.");


// Вариант 2*
// Метод отслеживания нажатий с выводом результата
string ReadLine(int num)
{
    string count = string.Empty;
    while (num > 0)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        count += key.KeyChar.ToString();
        num--;
    }
    return count;
}

// Метод поиска и подсчета положительных чисел из строки
int FindPosNumsInString(string line)
{
    int posNums = 0;
    Regex regex = new Regex(@"\d");
    MatchCollection matches = regex.Matches(line);
    if (matches.Count > 0)
    {
        foreach (Match match in matches)
        {
            int numInStr = int.Parse(match.Value);
            if (numInStr > 0) posNums++;
        }
    }
    return posNums;
}

// Ввод данных и вывод результата
int qntySmbls = ReadData("Сколько символов вы хотите ввести?");
string line = ReadLine(qntySmbls);
Console.WriteLine(line);
int result = FindPosNumsInString(line);
Console.WriteLine($"Количество введенных положительных чисел: {result}.");