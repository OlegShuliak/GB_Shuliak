// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод определения расстояния между двумя точками
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    // Определяем гиппотенузу из прямоугольного треугольника (теорема Пифагора)
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}


int coordX1 = ReadData("Введите координату x1: ");
int coordY1 = ReadData("Введите координату y1: ");
int coordX2 = ReadData("Введите координату x2: ");
int coordY2 = ReadData("Введите координату y2: ");
Console.WriteLine(CalcLen2D(coordX1, coordY1, coordX2, coordY2));


