// Считываем данные с консоли
string? inLine = Console.ReadLine();

// Проверим, чтобы данные были не пустыми
if (inLine != null)

{
    // Преобразовываем строковое значение в целочисленное (парсим)
    int inNumber = int.Parse(inLine);

    // Находим квадрат числа
    // int outNumb = inNumber * inNumber;
    int outStrtPow = (int)Math.Pow(inNumber,2);

    // Выводим данные в консоль
    // Console.WriteLine(outNumb);
    Console.WriteLine(outStrtPow);

}