// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет


Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
if(ValidateNumber(number)){
    Console.WriteLine(ThirdDigit(number));

}

bool ValidateNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третей цифры нет");
        return false;
    }
    return true;
}
int ThirdDigit(int num)
{
    while(num > 999)
    {
        num =num / 10;
    }
    return num % 10;

}





