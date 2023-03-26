// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[count] = sum;
        count++;
    }
    return array;
}

void ArrayPrinted(int[] arr)
{
    Console.Write("сумма по строкам[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int SmallestSumElements(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            min = i + 1;
        }
    }
    return min+1;
}


int[,] matrixRndInt = CreateMatrixRndInt(5, 5, -1, 6);
PrintMatrix(matrixRndInt);
int[] matrixToArray = MatrixToArray(matrixRndInt);
Console.WriteLine();
ArrayPrinted(matrixToArray);
int smallestSumElements = SmallestSumElements(matrixToArray);
Console.WriteLine(($"строка с наименьшей суммой элементов №{smallestSumElements}"));