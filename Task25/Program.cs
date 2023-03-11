// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("введите  число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA,numberB);

Console.WriteLine(exponentiation);



int Exponentiation(int numA, int numB)
{
int count = 1;
int numExpon=1;
    if (numB < 0)
    {
        numB = numB * -1;
    }
    while(count<=numB){
        numExpon=numExpon*numA;
        count++;
    }
return numExpon;

}
