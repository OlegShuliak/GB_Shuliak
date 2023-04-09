// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю

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

// Метод вычисления суммы элементов с нечетными индексами массива
int SumNmsOnOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

// Метод поиска пар в массиве (не получилось исключить определенные в пары ячейки массива)
void PairSrch(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        for (int j = i + 1; j < len; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.WriteLine($"Пара {arr[i]}, {arr[j]} с индексами {i}, {j}");
                break;
            }
        }
    }
}

// Вывод и заполнение массива случайными числами
int[] rndArr = Gen1DArr(10, 0, 10);
Print1DArr(rndArr);

// Вывод найденных пар чисел в консоль
PairSrch(rndArr);

// Вывод результата суммирования значений
Console.WriteLine("Сумма элементов массива с нечетными индексами равна: " + SumNmsOnOddPos(rndArr));





