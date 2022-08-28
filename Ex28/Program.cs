// Напишите программу, котоая принимает на вход число
// N и выдает произведение чисел от 1 до N

int GetFact(int a)
{
    int fact = 1;

    for(int i = 1; i <= a; i++)
    {
        fact = fact * i;
    }
    return fact;
}

Console.WriteLine("Введите ваше чило?");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {a} равна: ");
Console.Write(GetFact(a));