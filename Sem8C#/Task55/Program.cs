// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод заполнения двумерного массива числами в случайном порядке
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

// Метод транспонирования матрицы
int[,] Transp(int[,] matr)
{
    int[,] outMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            outMatr[j, i] = matr[i, j];
        }
    }
    return outMatr;
}


int m = ReadData("Введите число строк M:");
int n = ReadData("Введите число столбцов N:");
int[,] arr2D = Gen2DArr(m, n, 10, 100);
Print2DArray(arr2D);
Console.WriteLine("=============================");
int[,] res = Transp(arr2D);
Print2DArray(res);


