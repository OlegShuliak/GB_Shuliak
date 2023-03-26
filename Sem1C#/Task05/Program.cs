
// Считываем данные с консоли
string? numLineN = Console.ReadLine();

// Проверим, чтобы данные были не пустыми
if (numLineN != null)
{
    int numN = int.Parse(numLineN);
    int strtN = numN * (-1);
    // Создали строковую переменную для "накопления" результата
    string res = string.Empty;

    while (strtN <= numN)
    {
        // " " - так в результате появляется пробел между строковыми значениями
        res = res + strtN + " ";
        strtN++;
    }

    Console.WriteLine(res);

}








