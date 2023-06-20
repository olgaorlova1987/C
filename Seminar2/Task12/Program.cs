// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);
int numberIntThree = numberIntOne % numberIntTwo;
Console.WriteLine(numberIntThree);
if(numberIntThree !=0 )
{
    Console.WriteLine(numberIntThree);
}
else
{
    Console.WriteLine("Число кратно, остатка от деления нет");
}