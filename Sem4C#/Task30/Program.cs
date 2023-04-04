// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
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

// Метод заполнения одномерного массива
// единицами и нулями в случайном порядке
int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top+1);
    }
    return res;
}

int lenArr = ReadData("Выедите длину массива: ");
int[] arr = Gen1DArr(lenArr, 1, 0);
Print1DArr(arr);

