// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// * использовать сортировку вставкой

// Метод заполнения одномерного массива вещественными числами в случайном порядке
double[] Gen1DArr(int len, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    double[] res = new double[len];

    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return res;
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

// Метод определения разницы между мин и макс значениями массива
double DiffOfMinMax(double[] arr)
{
    double res = 0;
    double minNum = double.MaxValue;
    double maxNum = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (minNum > arr[i]) minNum = arr[i];
        if (maxNum < arr[i]) maxNum = arr[i];
    }
    res = maxNum - minNum;
    return res;
}

// Метод обмена элементов
void Swap(double[] array, int i, int j)
{
    double temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

//Метод сортировки вставкой
double[] InsertionSort(double[] inArray)
{
    double x;
    int j;
    for (int i = 1; i < inArray.Length; i++)
    {
        x = inArray[i];
        j = i;
        while (j > 0 && inArray[j - 1] > x)
        {
            Swap(inArray, j, j - 1);
            j -= 1;
        }
        inArray[j] = x;
    }
    return inArray;
}

// Вывод массива с вещественными числами
double[] arrDoubleNum = Gen1DArr(10, 0, 10);
Print1DArr(arrDoubleNum);

// Вывод разницы между макс и мин значениями массива методом
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {DiffOfMinMax(arrDoubleNum)}");

// Вывод результата сортировки массива вставкой
double[] arrInsSorted = InsertionSort(arrDoubleNum);
Print1DArr(arrInsSorted);

// Вывод разницы между мин и макс значениями из отсортированного массива
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {arrInsSorted[arrInsSorted.Length - 1] - arrInsSorted[0]}.");
