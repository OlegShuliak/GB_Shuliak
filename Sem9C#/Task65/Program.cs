// Ввести числа от M до N. Выввести все числа в промежутке от M до N.
// Использовать метод рекурсии.


//Метод общения с пользователем  - читает дынные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Рекурентный метод решения
string RecMN(int m, int n)
{
    if (m <= n) return m + " " + RecMN(m + 1, n);
    else return String.Empty;
}

// Ввод данных
int numM = ReadData("Введите число m: ");
int numN = ReadData("Введите число n: ");

// Вывод с защитой от "дурака", используем тернарный оператор
Console.WriteLine(RecMN((numM > numN) ? numN : numM, (numM > numN) ? numM : numN));

