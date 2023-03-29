
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Вариант 1

Console.WriteLine("Введите любое трехзначеное число");
int num = int.Parse(Console.ReadLine() ?? "0");
int res = num / 10 % 10;
Console.WriteLine(res);

// Вариант 2

char[] arr = new Random().Next(100, 1000).ToString().ToArray();
Console.WriteLine(arr);
Console.WriteLine(arr[1]);















