// Напишите программу, которая принимает на вход
// число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine()!);
string numberText = Convert.ToString(anyNumber);
int count = 0;
while (anyNumber > 0)
{
    //anyNumber = anyNumber / 10;
    anyNumber /= 10;
    count++;
}

//Console.WriteLine("Количество цифр в числе: " + count);
//Console.WriteLine("Количество цифр в числе: " + numberText.Length);

//Второй вариант:

Console.Clear();

int DigitsCount(int number)
{
    if(number == 0)
    {
        return 1;
    }
    int count = 0;
    for(; number > 0; count++)
    {
        number /= 10;
    }
    return count;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(DigitsCount(number));
