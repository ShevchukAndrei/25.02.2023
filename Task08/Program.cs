// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2; //или 1
while (count <= number){

    int lastDigit = count % 2;
    if (lastDigit == 0){
    
        Console.Write(count + " ");

    }
    count = count + 2; //или 1
}
// while (count <= number){

//     Console.Write(count + " ");
//     count = count + 2; -------------это для двойки без проверки чётности 
