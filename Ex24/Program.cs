// Напишите программу, которая на вход принимает число (А)
// и выдает сумму чисел от 1 до А.

int GetSum1ToA(int a)
{
    int sum = 0;

    for(int i = 1; i <= a; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

//Console.WriteLine("Введите ваше чило?");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Сумма чисел от 1 до {a} равна: ");
//Console.Write(GetSum1ToA(a));

// Второй вариант

int GetSum(int a)
{
    return a * (a + 1) / 2;
}

Console.WriteLine(GetSum(8));