// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.
// * Найдите площадь треугольника образованного пересечением 3 прямых


//Метод общения с пользователем  - читает дынные от пользователя
double ReadData(string msg)
{
    Console.WriteLine(msg);
    double res = double.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Вариант 1
// Метод определения координат пересечения прямых
void FindIntersectionPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (y == k2 * x + b2)
    {
        Console.WriteLine($"Коорданаты точки пересечения прямых x={x}, y={y}.");
    }
    else Console.WriteLine("Прямые параллельны.");
}

// Ввод коэффициентов и вывод результата
double b1 = ReadData("Введите коэффициент b1");
double b2 = ReadData("Введите коэффициент b2");
double k1 = ReadData("Введите коэффициент k1");
double k2 = ReadData("Введите коэффициент k2");
FindIntersectionPoint(b1, b2, k1, k2);


// Вариант 2*
// Метод определения координат пересечения прямых в массив
double[] FindIntersectionPointInArr(double b1, double b2, double k1, double k2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
    return arr;
}

// Метод определения длины стороны треугольника
double SideLength(double[] arr1, double[] arr2)
{
    return Math.Sqrt((arr1[0] - arr2[0]) * (arr1[0] - arr2[0]) + (arr1[1] - arr2[1]) * (arr1[1] - arr2[1]));
}

// Метод определения площади треугольника
double TriangleArea(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    double res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    return res;
}

// Ввод коэффициентов для определения координат вершин треугольника
double coeffB1 = ReadData("Введите коэффициент b1");
double coeffB2 = ReadData("Введите коэффициент b2");
double coeffB3 = ReadData("Введите коэффициент b3");
double coeffK1 = ReadData("Введите коэффициент k1");
double coeffK2 = ReadData("Введите коэффициент k2");
double coeffK3 = ReadData("Введите коэффициент k3");

// Определение координат вершин треугольника
double[] firstTop = FindIntersectionPointInArr(coeffB1, coeffB2, coeffK1, coeffK2);
double[] secondTop = FindIntersectionPointInArr(coeffB1, coeffB3, coeffK1, coeffK3);
double[] thirdTop = FindIntersectionPointInArr(coeffB2, coeffB3, coeffK2, coeffK3);
Console.WriteLine($"Координаты вершин треугольника [x, y]: [{firstTop[0]}, {firstTop[1]}], [{secondTop[0]}, {secondTop[1]}], [{thirdTop[0]}, {thirdTop[1]}].");

// Определяем длины сторон треугольника
double firstSide = SideLength(firstTop, secondTop);
double secondSide = SideLength(firstTop, thirdTop);
double thirdSide = SideLength(secondTop, thirdTop);
Console.WriteLine($"Длины сторон равны: {firstSide}, {secondSide}, {thirdSide}.");

// Определяем площадь треугольника и выводим результат
double area = TriangleArea(firstSide, secondSide, thirdSide);
Console.WriteLine($"Площадь заданного треугольника равна {area}.");