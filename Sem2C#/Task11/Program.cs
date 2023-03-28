// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

// Вариант 1

// Создаем переменную num и записываем в него значение
//  при помощи системного генератора
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int firstNum = num / 100;
int lastNum = num % 10;
int res = firstNum * 10 + lastNum;
Console.WriteLine(res);

// Вариант 2

// Генерируем случайное трехзначное число и записываем его в
// массив в строках
char[] arrNum = new System.Random().Next(10, 1000).ToString().ToArray();
Console.WriteLine(arrNum);

// Собираем новый массив из значений предыдущего в строках
char[] result = { arrNum[0], arrNum[2] };
Console.WriteLine(result);
