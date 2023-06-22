// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
string? numberString = Console.ReadLine();
int numberint = Convert.ToInt32(numberString);

if (numberint == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberint == 2)
{
    Console.WriteLine("Вторник");
}
if (numberint == 3)
{
    Console.WriteLine("Среда");
}
if (numberint == 4)
{
    Console.WriteLine("Четверг");
}
if (numberint == 5)
{
    Console.WriteLine("Пятница");
}
    
if (numberint == 6)
{
    Console.WriteLine("Суббота");
}
if (numberint == 7)
{
    Console.WriteLine("Воскресенье");
}
if (numberint >7  )
{
    Console.WriteLine("Такого дня недели нет!");
}
if(numberint >5)
{
    Console.WriteLine("Этот день выходной");
}
else
{
   Console.WriteLine("Этот день будний");
}
