// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод генерации трехмерного массива с случайными двузначными числами
int[,,] Gen3DArray(int indX, int indY, int indZ, int minNum, int maxNum)
{
    int[,,] mtr3D = new int[indX, indY, indZ];
    for (int i = 0; i < mtr3D.GetLength(0); i++)
    {
        for (int j = 0; j < mtr3D.GetLength(1); j++)
        {
            for (int k = 0; k < mtr3D.GetLength(2); k++)
            {
                mtr3D[i, j, k] = new Random().Next(minNum, maxNum + 1);
            }
        }
    }
    return mtr3D;
}

// Метод построчного вывода трехмерного массива с индексами
void PrintNums3DArr(int[,,] mtr3D)
{
    for (int i = 0; i < mtr3D.GetLength(0); i++)
    {
        for (int j = 0; j < mtr3D.GetLength(1); j++)
        {
            for (int k = 0; k < mtr3D.GetLength(2); k++)
            {
                Console.Write("{0}\t", $"{mtr3D[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine("");
        }
    }
}

// Генерируем массив и выводим результат в консоль
int[,,] rand3DArr = Gen3DArray(2, 2, 2, 10, 99);
PrintNums3DArr(rand3DArr);





