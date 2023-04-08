// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.

int globPosSum = 0;
int globNegSum = 0;

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

// Метод с использованием глобальных переменных
void NegPosSumV1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            globPosSum += arr[i];
        }
        else
        {
            globNegSum += arr[i];
        }
    }
}

// Метод с использованием локальных переменных и выводом массив
int[] NegPosSumV2(int[] arr)
{
    int positivSum = 0;
    int negotivSum = 0;
    int[] outArr = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negotivSum += arr[i];
        }
    }
    outArr[0] = positivSum;
    outArr[1] = negotivSum;
    return outArr;
}

// Метод с использованием локальных переменных и возвращением 2х значений
(int positiv, int negotiv) NegPosSumV3(int[] arr)
{
    int positivSum = 0;
    int negotivSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negotivSum += arr[i];
        }
    }
    return (positivSum, negotivSum);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
NegPosSumV1(testArr);
(int positiv, int negotiv) sum = NegPosSumV3(testArr);
int[] res = NegPosSumV2(testArr);

Console.WriteLine("Сумма положительных чисел в массиве(V1)" + globPosSum);
Console.WriteLine("Сумма отрицательных чисел в массиве(V1)" + globNegSum);

Console.WriteLine("Сумма положительных чисел в массиве(V2)" + res[0]);
Console.WriteLine("Сумма отрицательных чисел в массиве(V2)" + res[1]);

Console.WriteLine("Сумма положительных чисел в массиве(V3)" + sum.positiv);
Console.WriteLine("Сумма отрицательных чисел в массиве(V3)" + sum.negotiv);
