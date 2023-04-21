// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write("{0}\t", arr[i, j]);
        }
        Console.WriteLine();
    }
}

// Метод перемножения матриц
int[,] MatrixMultiplication(int[,] mtrA, int[,] mtrB)
{
    int[,] mtrC = new int[mtrA.GetLength(0), mtrB.GetLength(1)];
    for (int i = 0; i < mtrA.GetLength(0); i++)
    {
        for (int j = 0; j < mtrB.GetLength(1); j++)
        {
            mtrC[i, j] = 0;

            for (int k = 0; k < mtrA.GetLength(1); k++)
            {
                mtrC[i, j] += mtrA[i, k] * mtrB[k, j];
            }
        }
    }

    Console.WriteLine("Результат перемножения матриц:");
    return mtrC;
}

//Генерируем два массива, перемножаем, все массивы выводим в консоль
int[,] first2DArr = Gen2DArr(4, 4, 1, 9);
Print2DArray(first2DArr);
Console.WriteLine("=============================================");

int[,] second2DArr = Gen2DArr(4, 4, 1, 9);
Print2DArray(second2DArr);
Console.WriteLine("=============================================");

Print2DArray(MatrixMultiplication(first2DArr, second2DArr));
