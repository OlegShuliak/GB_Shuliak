// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.

// Метод заполнения двумерного массива
double[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// Метод печати двумерного массива, разные цвета диагоналей (работает, если массив до 5 строк либо 5 столбцов)*
void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j || i + 3 == j || i == j + 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}\t", arr[i, j]);
                Console.ResetColor();
            }
            else
            {
                if (i + 1 == j || i == j + 1 || i + 4 == j || i == j + 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}\t", arr[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    if (i + 2 == j || i == j + 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0}\t", arr[i, j]);
                        Console.ResetColor();
                    }
                    else Console.Write("{0}\t", arr[i, j]);
                }
            }
        }
        Console.WriteLine();
    }


}

// Метод нахождения среднего арифметического элементов столбцов
double[] ColMean(double[,] arr)
{
    double[] mean = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            mean[j] += arr[i, j];
        }
        mean[j] = mean[j] / arr.GetLength(1);
    }
    return mean;
}

// Метод печати одномерного массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Генерируем двумерный массив с выводом в консоль
Console.WriteLine("Сгенерированный двумерный массив:");
double[,] arr2D = Gen2DArr(5, 5, 1, 99);
Print2DArray(arr2D);

// Заполняем одномерный массив с средними арифметическими значений столбцов и выводим в консоль
Console.WriteLine("Массив с средними арифметическими значений из столбцов двумерного массива:");
double[] arrMean = ColMean(arr2D);
Print1DArr(arrMean);




