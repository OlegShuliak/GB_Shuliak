// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

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

// Метод нахождения числа в массиве
void SearchElem(int[] arr, int elem)
{
    bool elFnd = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            Console.WriteLine("Элемент найден в массиве");
            elFnd = true;
        }
    }
    if (elFnd == false)
    {
        Console.WriteLine("Элемент не найден в массиве");
    }
}

int elemFind = ReadData("Введите искомый элемент");
int[] arrForSearch = Gen1DArr(10, 0, 20);
Print1DArr(arrForSearch);
SearchElem(arrForSearch, elemFind);






