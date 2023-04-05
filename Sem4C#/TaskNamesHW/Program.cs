// Написать программу которая из имен через 
// запятую выберет случайное имя и выведет в терминал

// Создаем массив с знакими, которые хотим исключить при выборе имени
string[] separatingStrings = { ",", ".", "-", ":", ";" };

// Общение с пользователем - просим заполнить список имен
Console.WriteLine("Введите список имен через запятую");
string names = Console.ReadLine() ?? "0";

// Преобразуем введенную пользователем строку в массив, содержащий только имена
string[] nameList = names.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); // исключаем знаки из массива с исключениями + исключаем пробелы

// Определяем победителя
int arrLength = nameList.Length;
int winnerNumb = new Random().Next(0, arrLength);

// Вывод имени победителя в консоль
Console.WriteLine("Победитель - " + nameList[winnerNumb]);




