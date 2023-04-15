// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}



// Вариант 1
// Метод заполнения двумерного массива
int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// Метод печати двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }


}

// Метод поиска элемента в массиве
void FindElement(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) || j > arr.GetLength(1)) Console.WriteLine("Искомый элемент массива не существует.");
    else Console.WriteLine($"Искомый элемент массива равен {arr[i, j]}.");
}

// Заполняем случайный массив с 5 строками и 5 столбцами случайными значениями
int[,] arr2D = Gen2DArr(5, 5, 10, 100);
Print2DArray(arr2D);

// Вводим позицию элемента массива
int line = ReadData("Введите номер строки массива:");
int column = ReadData("Введите номер столбца массива:");

// Выполняем поиск элемента в массиве
FindElement(arr2D, line, column);



//Вариант 2*
// Метод создания одномерного массива с числами фиббоначи
int[] FibNums(int len)
{
    int[] arr = new int[len];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < len; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

// Метод заполнения двумерного массива числами Фиббоначи
int[,] Gen2DArrFibb(int[] arr1D, int countRow, int countColumn)
{
    int[,] arr2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = arr1D[new Random().Next(0, arr1D.Length)];
        }
    }
    return arr2D;
}

// Метод печати двумерного массива с выделенным цветом элементом
void Print2DArrayFibb(int[,] arr, int iFind, int jFind)
{
    Console.WriteLine("Искомый элемент выделен зеленым цветом:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != iFind || j != jFind) Console.Write(arr[i, j] + " ");
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arr[i, j] + " ");
                Console.ResetColor();
            }

        }
        Console.WriteLine();
    }


}

// Метод поиска элемента в массиве с числами Фиббоначи
void FindElementFibb(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) || j > arr.GetLength(1)) Console.WriteLine("Искомый элемент массива не существует.");
    else Print2DArrayFibb(arr, i, j);
}

// Заполняем массивы числами Фиббоначи
int[] fibbonachi = FibNums(11);
int[,] fibbonachi2D = Gen2DArrFibb(fibbonachi, 5, 5);
Print2DArray(fibbonachi2D);

// Вводим позицию элемента массива
int lineFibb = ReadData("Введите номер строки массива:");
int columnFibb = ReadData("Введите номер столбца массива:");

// Выполняем поиск элемента в массиве
FindElementFibb(fibbonachi2D, lineFibb, columnFibb);
