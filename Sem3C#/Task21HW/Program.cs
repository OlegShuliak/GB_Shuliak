// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// Вариант 1
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод определения расстояния между двумя точками
double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    // Корень из суммы квадратов разностей координат точек и будет расстоянием между ними в 3D пространстве
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}

// Вводим координаты точек с консли
int coordX1 = ReadData("Введите координату x1: ");
int coordY1 = ReadData("Введите координату y1: ");
int coordZ1 = ReadData("Введите координату z1: ");
int coordX2 = ReadData("Введите координату x2: ");
int coordY2 = ReadData("Введите координату y2: ");
int coordZ2 = ReadData("Введите координату z2: ");

// Выводим результат в консоль
Console.WriteLine("Расстояние между двумя точками в пространстве 3D равно " + CalcLen3D(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2));









