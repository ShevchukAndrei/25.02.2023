// Console.WriteLine("введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 % 7 ==0 && number1 % 23 == 0) {
//     Console.WriteLine("да");
// }
// else { Console.WriteLine("нет");
// }

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
bool IsDivided(int num)
{
    return number % 7 == 0 && number % 23 == 0;
}

if (IsDivided(number))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}