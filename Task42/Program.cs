// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("введите десятичное  число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DecToBin( numberA)) ;

int DecToBin(int num)
{
    int res =0;
    int multiplier =1;
    while(num>0)
    {
        res +=(num%2)*multiplier;
        num=num/2;
        multiplier *=10;
    }
    return res;
}



