// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

// Метод сортировки подсчетом max>min
int[] CountingSort(int[] array, int k)
{
    int[] count = new int[k + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i]]++;
    }

    int index = array.Length - 1;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index--;
        }
    }
    return array;
}

// Метод сортировки значений в строках массива max>min
void SortArray(int[,] mtr)
{
    int[] buf = new int[mtr.GetLength(1)];
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            buf[j] = mtr[i, j];
        }

        CountingSort(buf, 1000);

        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = buf[j];
        }
    }
}

// Генерируем двумерный массив, сортируем и выводим результаты в консоль
int[,] rand2DArr = Gen2DArr(10, 10, 10, 99);
Print2DArray(rand2DArr);
Console.WriteLine("=========================");
SortArray(rand2DArr);
Print2DArray(rand2DArr);
