// Напишите программу, которая принимает на вход число и выдает сумму
// цифр в числе.

Console.Clear();

int SumOfDigits(int a)
{
    int result = 0;
    for (int i = 0; a > 0; i++)
    {
        int help = a % 10;
        result = result + help;
        a /= 10; 
    }
    return result;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {a} равна: {SumOfDigits(a)}");