// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

// Метод определения строки массива с наименьшей суммой элементов
void MinSumElementLine(int[,] mtr)
{
    int minLine = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            sum += mtr[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            minLine = i;
        }
    }
    Console.WriteLine($"Минимальная сумма эелементов {minSum} в {minLine+1}-й строке.");
}

// Генерируем двумерный массив, ищем необходимую строку выводим результаты в консоль
int[,] rand2DArr = Gen2DArr(5, 3, 1, 9);
Print2DArray(rand2DArr);
MinSumElementLine(rand2DArr);


