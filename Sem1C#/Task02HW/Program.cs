// Просим пользователя ввести данные для сравнения (тип данных строка)
Console.WriteLine("Введите первое число");
string? numLine1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? numLine2 = Console.ReadLine();

// Проверяем, что данные не пустые
if ((numLine1 != null) && (numLine2 != null))
{
    // Преобразуем данные в числовые
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    // Добавляем две переменные для вывода результата (тип данных строка)
    string max = string.Empty;
    string min = string.Empty;

    // Сравниваем данные
    if (num1 > num2)
    {
        max = max + num1;
        min = min + num2;
    }

    else
    {
        max = max + num2;
        min = min + num1;
    }

    // Вывод данных в терминал
    Console.Write("Max = ");
    Console.WriteLine(max);
    Console.Write("Min = ");
    Console.WriteLine(min);
}








