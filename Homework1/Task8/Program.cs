﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using System;
Console.WriteLine("Введите число N");
string? n = Console.ReadLine();
int b= Convert.ToInt32(n);
int i= 1;
for(i<= b; i%2 == 0; i++;)
{
Console.WriteLine(i);
Console.WriteLine("Все четные числа от 1 до N");
}
