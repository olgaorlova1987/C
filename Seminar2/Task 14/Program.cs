// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

using System;

Console.WriteLine("Введите число:");
string? numberStringOne = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberB = numberIntOne % 7;
int numberC = numberIntOne % 23;
if (numberB == 0 && numberC ==0)
{
    Console.WriteLine("Число красно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}