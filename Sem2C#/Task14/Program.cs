// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.


// Вариант 1

int num = int.Parse(Console.ReadLine() ?? "0");
bool res = (num % 7 == 0 && num % 23 == 0);
if (res) Console.WriteLine("Число " + num + " кратно 7 и 23");
else Console.WriteLine("Число " + num + " не кратно 7 и 23");




