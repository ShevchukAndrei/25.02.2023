﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int multiplication = Multiplication(number);
Console.WriteLine($"произведение чисел от 1 до {number} : {multiplication}");


int Multiplication(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}