// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

// Метод печати одномерного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод определения ячейки с наименьшим элементом
int[] FindMinElem(int[,] mtr)
{
    int[] outA = new int[2];
    int minElem = int.MaxValue;
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            if (minElem > mtr[i, j])
            {
                minElem = mtr[i, j];
                outA[0] = i;
                outA[1] = j;
            }
        }
    }
    return outA;
}

// Метод удаления строки и столбца, в пересечении которых ячейка с наименьшим элементом
int[,] ReGen2DArr(int[,] mtr, int[] point)
{
    int[,] outMtr = new int[mtr.GetLength(0) - 1, mtr.GetLength(1) - 1];
    int k = 0;
    int m = 0;
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            if (i != point[0] && j != point[1])
            {
                outMtr[k, m] = mtr[i, j];
                m++;
            }
        }
        if (i != point[0]) k++;
    }
    return outMtr;
}

int m = ReadData("Введите число строк M:");
int n = ReadData("Введите число столбцов N:");
int[,] arr2D = Gen2DArr(m, n, 10, 99);
Print2DArray(arr2D);
Console.WriteLine("=============================");
int[] minPoint = FindMinElem(arr2D);
Print1DArr(minPoint);
Console.WriteLine("=============================");
int[,] res = ReGen2DArr(arr2D, minPoint);
Print2DArray(res);


