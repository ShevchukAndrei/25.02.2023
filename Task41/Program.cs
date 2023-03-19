// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3



Console.WriteLine("Cколько Вы хотите ввести чисе? : ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] array=ArrayFilling(numberM);
ArrayPrinted(array);
int positiveNumbers=PositiveNumbers(array);
Console.WriteLine($"количество элементов больше нуля = {positiveNumbers}");


int[] ArrayFilling(int numM)
{
    int[] arr= new int [numM];
    for (int i = 0; i < numM; i++)
    {
        Console.WriteLine("введите целое число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return arr;
}

void ArrayPrinted(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int PositiveNumbers(int[] arr)
{int count=0;
    for (int i = 0; i <arr.Length; i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
    }
    return count;
}