// Задача 28: Напишите программу, которая 
//принимает на вход число N и выдаёт произведение 
//чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int func(int number)
{
    int colvo = 1;
    while (number >0)
    {
        number = number * colvo;
        colvo++;
    }
    return colvo;
}
int number = ReadInt();
int colvo1 = func(number);

Console.WriteLine($"Произведение чисел от 1 до N: {colvo1}");