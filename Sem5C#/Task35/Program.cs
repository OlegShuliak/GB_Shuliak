// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10,99].

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

//Метод нахождения количества элементов 
int ElemInRange (int[] arr, int minNum, int maxNum)
{
    int res=0;
    for (int i=0; i<arr.Length; i++)
    {
    if (arr[i]>=minNum && arr[i]<=maxNum) res+=1;
    }
    return res;
}

int[] arrNums = Gen1DArr(123, 0, 1000);
Print1DArr(arrNums);
int result = ElemInRange(arrNums, 10, 99);
Console.WriteLine($"Количество чисел из диапазона [10;99]: " + result);




