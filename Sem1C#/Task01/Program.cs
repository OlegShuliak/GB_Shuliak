// Считываем данные с консоли
string? inLine1 = Console.ReadLine();
string? inLine2 = Console.ReadLine();

// Проверим, чтобы данные были не пустыми
if (inLine1 != null && inLine2 != null)

{
    // Парсим значения
    int numLine1 = int.Parse(inLine1);
    int numLine2 = int.Parse(inLine2);

    if (numLine1 == numLine2 * numLine2)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}