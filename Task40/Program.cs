// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.



Console.WriteLine("введите длинну отрезка  AB: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  длинну отрезка BC: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  длинну отрезка CA: ");
int numberC = Convert.ToInt32(Console.ReadLine());
bool isExistTriangle = IsExistTriangle(numberA, numberB, numberC);
Console.WriteLine(isExistTriangle
? "может существовать"
: "не может существовать ");

bool IsExistTriangle(int numA, int numB, int numC)
{
    return numA < numB + numC && numB < numA + numC && numC < numA + numB;
}


