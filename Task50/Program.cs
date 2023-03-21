// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет


int[,] matrixRndInt = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrixRndInt);
Console.WriteLine("введите позицию элемента1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите позицию элемента2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
FindingElement(matrixRndInt, number1, number2);


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

void FindingElement(int[,] matrix, int num1, int num2)
{
    if (num1 < matrix.GetLength(0) && num2 < matrix.GetLength(1))
    {
        Console.WriteLine($"значение элемента [{num1},{num2}]=> {matrix[num1, num2]}");
    }
    else
    {
        Console.WriteLine($"элемента [{num1},{num2}] нет.");
    }
}
