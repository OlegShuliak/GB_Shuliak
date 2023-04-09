// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька


// Метод заполнения одномерного массива числами в случайном порядке
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
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

// Метод обмена элементов
void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

// Сортировка пузырьком
int[] BubbleSort(int[] array)
{
    int len = array.Length;
    for (int i = 1; i < len; i++)
    {
        for (int j = 0; j < len - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                Swap(array, j, j + 1);
            }
        }
    }
    return array;
}

// Метод сортировки подсчетом
int[] CountingSort(int[] array, int k)
{
    int[] count = new int[k + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i]]++;
    }

    int index = 0;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i;
            index++;
        }
    }
    return array;
}

// Метод определения количества четных чисел в массиве
int QtyEvnNums(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    return res;
}

// Заполняем массив и печатаем результат сортировки и подсчета
int[] rndArr = Gen1DArr(10, 100, 999);
Console.Write("Случайный массив из трехзначных чисел: ");
Print1DArr(rndArr);

Console.Write("Массив отсортированный методом пузырька: ");
DateTime d1 = DateTime.Now;
Print1DArr(BubbleSort(rndArr));
Console.WriteLine("Время, потраченное на сортировку пузырьком - " + (DateTime.Now - d1));

Console.Write("Массив отсортированный методом подсчета: ");
DateTime d2 = DateTime.Now;
Print1DArr(CountingSort(rndArr, 999));
Console.WriteLine("Время, потраченное на сортировку подсчетом - " + (DateTime.Now - d2));

Console.WriteLine("Количество четных чисел в массиве: " + QtyEvnNums(rndArr));




