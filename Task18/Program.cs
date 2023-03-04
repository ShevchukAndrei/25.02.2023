// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
// Console.WriteLine("введите координаты точки  ");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты точки  ");
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());
// int quarter=Quarter(xCoordinate,yCoordinate);
// string result=quarter > 0 
// ? $"Указанные координаты соответствуют четверти -> {quarter}"
// :"введены неверные координаты";
// Console.WriteLine(result);


Console.WriteLine("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());


string rangeQuarter = RangeQuarter(numberQuarter);
string result = rangeQuarter != "Error"
                ? $" Данной четверти соответсвует диапазон -> {rangeQuarter}"
                : "Введен некорректный номер четверти";
Console.WriteLine(result);

string RangeQuarter(int numQuarter)
{
    if (numQuarter == 1) return "x > 0, y > 0";
    if (numQuarter == 2) return "x < 0, y > 0";
    if (numQuarter == 3) return "x < 0, y < 0";
    if (numQuarter == 4) return "x > 0, y < 0";
    return "Error";
}

