// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 2;
if (lastDigit == 0){
    Console.WriteLine($"чило {number} является чётным ");
}
else Console.WriteLine($"число {number} является нечетным"); //стало
// else Console.WriteLine("нет ответа: запустите программу заново и введите другое целое число"); БЫЛО