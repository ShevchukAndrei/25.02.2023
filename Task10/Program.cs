﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if ( number>99 || number<1000) {

// int secondDigit = number / 10 % 10 ;
// Console.WriteLine(secondDigit);
// }
int secondDigit = SecondDigit(number);
int SecondDigit (int num)
{
    int result = num / 10 % 10 ;
return result;
}
Console.WriteLine(secondDigit);