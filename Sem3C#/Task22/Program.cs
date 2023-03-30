// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.

//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод который в первой строке пишет ряд чисол до N,
// а во второй их квадраты
string LineGen(int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}

int numN = ReadData("Введите число N");
Console.WriteLine(LineGen(numN, 1));
Console.WriteLine(LineGen(numN, 2));




