﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number2 > 0)
{
    if (number1 > number2)
    {
        int temp;
        temp = number2;
        number2 = number1;
        number1 = temp;
    }
    int smNumbersRange = SumNumbersRange(number1, number2);
    Console.WriteLine(smNumbersRange);
}
else Console.WriteLine("Ошибка ввода!");

int SumNumbersRange(int num1, int num2)
{
    if (num1 == num2) return num2;
    else return num1 + SumNumbersRange(num1 + 1, num2);
}
