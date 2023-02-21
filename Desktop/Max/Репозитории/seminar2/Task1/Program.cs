// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int res = number * number;
Console.WriteLine(res);

if (res > 100);
{
    Console.WriteLine("Да");
}




