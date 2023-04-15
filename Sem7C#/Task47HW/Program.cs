// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод заполнения двумерного массива вещественными числами в случайном порядке
double[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return arr;
}

// Метод печати двумерного массива, каждая цифра вещественных чисел разного цвета
void Print2DArray(double[,] arr)
{
    // Создаем коллекцию цветов
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            char[] arrRandCol = arr[i, j].ToString().ToCharArray();
            for (int k = 0; k < arrRandCol.Length; k++)
            {
                Console.ForegroundColor = col[new Random().Next(0, 16)];
                Console.Write(arrRandCol[k]);
                Console.ResetColor();
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// Задаем размеры массива, диапазон случайных чисел в нем, выводим сгенерированный массив
int row = ReadData("Введите количество строк");
int col = ReadData("Введите количество столбцов");
double[,] arr2D = Gen2DArr(row, col, 10, 99);
Print2DArray(arr2D);



