// напишите программу которая определяет присутствие ли заданное число в массиве

int[] array = CreateArrayRndInt(12, -9 , 9);
PrintArray(array);

Console.WriteLine("введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(number, array) 
? $"число {number} найдено" 
: $"число {number} не найдено");

bool FindNumber(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]==num) return true;

    }
    return false;
}


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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

