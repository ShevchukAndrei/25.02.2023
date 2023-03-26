// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int power=Power(number1,number2);
 Console.WriteLine(power); 
int Power(int num1,int num2)
 {
     if (num2 == 0) return 1;
     else return num1*Power(num1,num2-1);
 }