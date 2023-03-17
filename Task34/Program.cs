// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void ArrayPrinted(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int QuantityEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = CreateArrayRndInt(12, 100, 999);
ArrayPrinted(array);
int quantityEvenNumbers = QuantityEvenNumbers(array);
Console.WriteLine($"количество чётных чисел в массиве = {quantityEvenNumbers}");
