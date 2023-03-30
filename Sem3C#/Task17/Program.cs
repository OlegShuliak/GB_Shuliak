// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


// Метод определяет четверть по координатам точки
void PrintQuoterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в первой четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в второй четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в третьей четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в четвертой четверти");
}

int coordX = ReadData("Введите координату x: ");
int coordY = ReadData("Введите координату y: ");
PrintQuoterTest(coordX, coordY);










