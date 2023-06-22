// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
string? numberStringOne = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);

for (numberIntOne > 99; int number = (numberIntOne/10) %10;)
{
    if (numberIntOne < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else 
    {
        Console.WriteLine($"Третья цифра:{number}"); 
    }
}
       


