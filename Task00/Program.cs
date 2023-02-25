// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Введите целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int square = numberA*numberA;
Console.WriteLine($"Квадрат числа {numberA}={square}");
