
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 1000 -> {number}");
// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int result =  firstDigit*10 + lastDigit;
// Console.WriteLine($"{result}");



int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");


int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Результат = {removeSecondDigit}");

int RemoveSecondDigit (int num) 
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}