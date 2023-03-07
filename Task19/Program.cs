// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (ValidateNumber(number))
{
    Palindrome(number);
}


bool ValidateNumber(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    if (num > 10000 && num <= 99999)
    {
        return true;
    }
    Console.WriteLine("число не пятизначное");
    return false;

}


bool Palindrome(int num)
{

    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int num3 = num / 100 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Число -> {num} является палиндромом");
        return true;

    }
    Console.WriteLine($"Число -> {num} не является палиндромом");
    return false;
}






