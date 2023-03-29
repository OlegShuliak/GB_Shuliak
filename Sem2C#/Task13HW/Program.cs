// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Вариант 1

int num = new Random().Next(0, 10000);
Console.WriteLine(num);
bool res = num > 100;
if (res)
{
    char[] arr = num.ToString().ToArray();
    Console.WriteLine(arr[2]);
}
else Console.WriteLine("Третьей цифры нет");

// Вариант 2 (задание со *, вариант для числа длиной до 10 цифр не используя char или string)

Console.WriteLine("Введите любое число > 99");
Int64 num1 = Int64.Parse(Console.ReadLine() ?? "0");
bool res1 = num1 < 100;
if (res1)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    while (num1 >= 999)

    {
        num1 = num1 / 10;
    }

    Console.WriteLine(num1 % 10);
}











