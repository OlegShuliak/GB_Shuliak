
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

// Вариант 1

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine() ?? "0");
bool dayWeek = ((day > 0) && (day < 8));
if (dayWeek)
{
    if (day <= 5) Console.WriteLine("Рабочий день");
    else Console.WriteLine("Выходной день");
}
else Console.WriteLine("Не день недели");

// Вариант 2 (вариант со * - Сделать вариант с использованием конструкции Dictionary)
Console.WriteLine("Введите цифру, обозначающую день недели");
int day1 = int.Parse(Console.ReadLine() ?? "0");
bool dayWeek1 = ((day1 > 0) && (day1 < 8));
var dayDic = new Dictionary<int, string>()
{
    [1] = "Рабочий день:(",
    [2] = "Рабочий день:(",
    [3] = "Рабочий день:(",
    [4] = "Рабочий день:(",
    [5] = "Рабочий день:(",
    [6] = "Выходной день:)",
    [7] = "Выходной день:)",
};

if (dayWeek1)
{
    Console.WriteLine(dayDic[day1]);
}
else Console.WriteLine("Не день недели");







