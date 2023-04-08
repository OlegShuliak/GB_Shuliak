// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.

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

// Метод замены элементов массива 1
int[] ChngNumArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = arr[i] * (-1);
    return arr;
}

// Метод с использованием ссылочного типа переменных 2
void InversArrRef(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = arr[i] * (-1);
}

// Генерируем массив
int[] arrayNums = Gen1DArr(10, -10, 10);
Print1DArr(arrayNums);

// Вывод результата 1го метода
int[] arrayNumsChng = ChngNumArr(arrayNums);
Print1DArr(arrayNumsChng);

// Вывод результата второго метода
InversArrRef(arrayNums);
Print1DArr(arrayNums);