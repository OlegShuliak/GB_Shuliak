// Напишите программу, которая заполнит спирально массив 4 на 4.

// Метод заполнения двумерного массива числами спиралью
int[,] GenSpiral2DArr(int countRow, int countColumn)
{
    int[,] resArr = new int[countRow, countColumn];
    int iMin = 0;
    int jMin = 0;
    int iMax = countRow - 1;
    int jMax = countColumn - 1;
    int iCheck = 0;
    int jCheck = 0;
    int num = 1;

    while (num <= countRow * countColumn)
    {
        if (iCheck < iMax && jCheck < jMax) // Проход строки вправо
        {
            int i = iMin;
            for (int j = jMin; j <= jMax; j++)
            {
                resArr[i, j] += num;
                num++;
            }
            jCheck = jMax;
            iMin++;
        }

        else if (iCheck < iMax && jCheck == jMax) // Проход столбца вниз
        {
            int j = jMax;
            for (int i = iMin; i <= iMax; i++)
            {
                resArr[i, j] += num;
                num++;
            }
            iCheck = iMax;
            jMax--;
        }

        else if (iCheck == iMax && jCheck > jMax) // Проход строки влево
        {
            int i = iMax;
            for (int j = jMax; j >= jMin; j--)
            {
                resArr[i, j] += num;
                num++;
            }
            jCheck = jMin;
            iMax--;
        }

        else 
        {
            int j = jMin;
            for (int i = iMax; i >= iMin; i--)
            {
                resArr[i, j] += num;
                num++;
            }
            iCheck = iMin;
            jMin++;
        }
    }
    return resArr;
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

int[,] spiralMatrix = GenSpiral2DArr(10, 5);
Print2DArray(spiralMatrix);







