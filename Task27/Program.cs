// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = SumDigit(number);
Console.WriteLine(SumDigit(number));


int SumDigit(int num)
{
    int sum = 0;
    int numDigit = 0;

    while (num > 0)
    {
        numDigit = num % 10;
        num = num / 10;
        sum = sum + numDigit;
    }
    return sum;
}



// int numberDigit = NumberDigit(number);
// Console.WriteLine($"количество цифр в числе: {numberDigit}");


// int NumberDigit(int num)
// {
//     int digit = 0;
//     while (num > 0)
//     {
//         num /= 10;
//         digit++;
//     }
//     return digit;
// }