// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.

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

// Метод произведенияя пар в одномерном массиве
int[] ConvertArr(int[] arr)
{
    int len = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] outArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return outArr;
}

int[] arrRndm = Gen1DArr(7, 0, 5);
Print1DArr(arrRndm);
int[] arrRes = ConvertArr(arrRndm);
Print1DArr(arrRes);






