﻿// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// Вариант 1
//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод проверки пятизначного числа на палиндромность
void PalindromTest(int num)
{
    char[] arr = num.ToString().ToArray();
    if (arr[0] == arr[4] && arr[1] == arr[3]) Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");
}

// Вызов метода для ввода числа
int numTest = ReadData("Введите пятизначное число");
// Вызов метода для проверки числа на палиндромность + проверка, является ли число пятизначным
if (numTest > 9999 && numTest < 100000) PalindromTest(numTest);
else Console.WriteLine($"Число {numTest} не является пятизначным");


// Вариант 2* - Сделать вариант через СЛОВАРЬ четырехзначных палиндромов 
//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод поиска палиндромных четырехзначних числе в словаре по совпадению ключа
void PalTest(int num)
{
    // Добавление словаря
    var palDic = new Dictionary<int, string>()
    {
        [1111] = "Палиндром", [1221] = "Палиндром", [1331] = "Палиндром", [1441] = "Палиндром", [1551] = "Палиндром", [1661] = "Палиндром", [1771] = "Палиндром", [1881] = "Палиндром", [1991] = "Палиндром",
        [2112] = "Палиндром", [2222] = "Палиндром", [2332] = "Палиндром", [2442] = "Палиндром", [2552] = "Палиндром", [2662] = "Палиндром", [2772] = "Палиндром", [2882] = "Палиндром", [2992] = "Палиндром",
        [3113] = "Палиндром", [3223] = "Палиндром", [3333] = "Палиндром", [3443] = "Палиндром", [3553] = "Палиндром", [3663] = "Палиндром", [3773] = "Палиндром", [3883] = "Палиндром", [3993] = "Палиндром",
        [4114] = "Палиндром", [4224] = "Палиндром", [4334] = "Палиндром", [4444] = "Палиндром", [4554] = "Палиндром", [4664] = "Палиндром", [4774] = "Палиндром", [4884] = "Палиндром", [4994] = "Палиндром",
        [5115] = "Палиндром", [5225] = "Палиндром", [5335] = "Палиндром", [5445] = "Палиндром", [5555] = "Палиндром", [5665] = "Палиндром", [5775] = "Палиндром", [5885] = "Палиндром", [5995] = "Палиндром",
        [6116] = "Палиндром", [6226] = "Палиндром", [6336] = "Палиндром", [6446] = "Палиндром", [6556] = "Палиндром", [6666] = "Палиндром", [6776] = "Палиндром", [6886] = "Палиндром", [6996] = "Палиндром",
        [7117] = "Палиндром", [7227] = "Палиндром", [7337] = "Палиндром", [7447] = "Палиндром", [7557] = "Палиндром", [7667] = "Палиндром", [7777] = "Палиндром", [7887] = "Палиндром", [7997] = "Палиндром",
        [8118] = "Палиндром", [8228] = "Палиндром", [8338] = "Палиндром", [8448] = "Палиндром", [8558] = "Палиндром", [8668] = "Палиндром", [8778] = "Палиндром", [8888] = "Палиндром", [8998] = "Палиндром",
        [9119] = "Палиндром", [9229] = "Палиндром", [9339] = "Палиндром", [9449] = "Палиндром", [9559] = "Палиндром", [9669] = "Палиндром", [9779] = "Палиндром", [9889] = "Палиндром", [9999] = "Палиндром",
    };
    
    // Проверка, есть ли число в словаре (по совпадению ключа)
    bool palKey = palDic.ContainsKey(num);
    // Вывод результата проверки
    if (palKey) Console.WriteLine(palDic[num]);
    else Console.WriteLine("Не палиндром");
}

// Ввод данных
int numTestPal = ReadData("Введите четырехзначное число");
// Проверка, чтобы введенное число было четырехзначным
bool testNumFour = (numTestPal > 999 && numTestPal < 10000);
// Вызов метода определения полиндромности и вывода результата
if (testNumFour) PalTest(numTestPal);
else Console.WriteLine("Не явялется четырехзначным числом");



