// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод для определения возможных координат
void PrintAnswer(int num)
{
    if (num == 1) Console.WriteLine("x>0, y>0");
    if (num == 2) Console.WriteLine("x>0, y<0");
    if (num == 3) Console.WriteLine("x<0, y<0");
    if (num == 4) Console.WriteLine("x<0, y>0");
}

// Вводим номер четверти
int quoter = ReadData("Введите номер четверти");
// Используем метод для определения возможных координат при соблюдении условий
if (quoter > 0 && quoter < 5) PrintAnswer(quoter);
else Console.WriteLine("Нет такой четверти");



