// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// int remains = number1 % number2;
// string result = remains == 0 ? "кратно" : $"некратно остаток {remains}";
Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int remains=Remains(number1,number2);
string result = remains == 0 ? "кратно" : $"некратно остаток {remains}";
Console.WriteLine(result);
int Remains(int num1, int num2)
{
    return num1 % num2;
}
