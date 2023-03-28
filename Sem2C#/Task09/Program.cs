
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Обращаемся к системному рандомайзеру
System.Random numSintezator = new System.Random();

// Вариант 1

// Генерируем случайное число от 10 до 100, первое число включено, последнее нет.
int rndNum = numSintezator.Next(10,100);
Console.WriteLine(rndNum);
int firstNum = rndNum/10;
int secondNum = rndNum%10;
if (firstNum>secondNum)
{
Console.WriteLine("Перове число " + firstNum + " больше второго " + secondNum);
}
else
{
Console.WriteLine("Перове число " + firstNum + " меньше второго " + secondNum);
}


// Вариант 2

// Создаем массив digits - используя системный синтезатор, генерируем число
//переводим значения в строковые, добавляем в массив 
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

// При переводе данных из string в int (в случае ниже) необходимо отнять 48
firstNum = (int) (digits[0])-48;
secondNum =(int) (digits[1])-48;

// Тернарный оператор - <переменная> = <условие>?<значение1>:<значение2>
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);












