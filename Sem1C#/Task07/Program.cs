
Console.WriteLine ("Введите трехзначное число");

string? numbLine = Console.ReadLine();

if (numbLine != null)
{
    // Первый вариант решения через строковые значения путем преобразования введенной строки (трехзначного числа) в массив
    char[] charArr = numbLine.ToCharArray();
    Console.WriteLine(charArr[charArr.Length-1]);
    
    // Второй вариант решения через числовые значения
    int num = int.Parse(numbLine);
    // при делении через % программа показывает остаток от деления, при / показывает результат деления без остатка
    int res = num%10;
    Console.WriteLine(res);
}
