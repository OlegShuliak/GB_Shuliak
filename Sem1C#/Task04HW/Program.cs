// Просим пользователя ввести три любых числа
Console.WriteLine("Введите три числа");
string? numLine1 = Console.ReadLine();
string? numLine2 = Console.ReadLine();
string? numLine3 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if ((numLine1 != null) && (numLine2 != null) && (numLine3 != null))
{
    // Парсим данные
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    int num3 = int.Parse(numLine3);

    // Вводим переменную для вывода результата равную первому введенному значению
    int max = num1;

    // Сравниваем оставшиеся введеннные пользователем значения
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

    // Выводим результат в терминале
    Console.Write("Max = ");
    Console.WriteLine(max);
}
