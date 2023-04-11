// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)

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

// Метод классического разворота массива
void SwapArray(int[] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        // (arr[i], arr[arr.Length - 1 - i] = arr[arr.Length - 1 - i], arr[i]); // Упрощенный (современный) вариант
        buf = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = buf;
    }

}

// Метод разворота с созданием нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[outArr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

int[] testArray = Gen1DArr(12, 10, 100);
Print1DArr(testArray);

DateTime d1 = DateTime.Now;
int[] newArray = SwapNewArray(testArray);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
SwapArray(testArray);
Console.WriteLine(DateTime.Now - d2);

Print1DArr(newArray);
Print1DArr(testArray);