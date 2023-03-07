// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberDigit = NumberDigit(number);
Console.WriteLine($"количество цифр в числе: {numberDigit}");

int NumberDigit(int num)
{
    int digit = 0;
    while (num > 0)
    {
        num /= 10;
        digit++;
    }
    return digit;
}