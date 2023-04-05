// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод печати массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод заполнения массива случайными числами
int[] GenArr(int len, int min, int max)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

// Ввод длины массива, его минимального и максимального значения в ячейках
int len = ReadData("Введите длину массива");
int min = ReadData("Введите минимальное значение массива");
int max = ReadData("Введите максимальное значение массива");
// Вывод результата
PrintArr(GenArr(len, min, max));

