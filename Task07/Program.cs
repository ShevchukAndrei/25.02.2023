﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
Console.WriteLine($"последняя цифра числа: {lastDigit}");