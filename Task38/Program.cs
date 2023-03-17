// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arrayDouble = CreateArrayRndInt(5, 2, 12);
ArrayPrinted(arrayDouble);
double maxNumber = MaxNumber(arrayDouble);
double minNumber = MinNumber(arrayDouble);

Console.WriteLine($"максимальное число массива => {maxNumber}");
Console.WriteLine($"минимальное => {minNumber}");
double difference = maxNumber - minNumber;
double roundingDifference = Math.Round(difference, 1);
Console.WriteLine($"разница между максимальным и минимальным элементов массива => {roundingDifference}");



double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void ArrayPrinted(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " / ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxNumber(double[] arr)
{
    double maximum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (maximum < arr[i])
        {
            maximum = arr[i];
        }

    }
    return maximum;
}
double MinNumber(double[] arr)
{
    double minimum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minimum > arr[i])
        {
            minimum = arr[i];
        }
    }
    return minimum;
}
