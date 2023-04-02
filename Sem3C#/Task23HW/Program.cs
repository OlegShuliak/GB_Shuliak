// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.1

// Вариант 1
// Общение с пользователем - метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Ввод данных
int num = ReadData("Введите число N");
// Вывод в консоль наименоваия столбцов в консоли
Console.WriteLine("Число\tКуб");
// Заполнение столбцов в косоли
for (int i = 0; i <= num; i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
}










