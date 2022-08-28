// Напишите цикл, который принимает на вход два числа (А и В) и
// возводит число А в натуральную степень В

Console.Clear();

int DegreeAByB (int a, int b)
{
    int i = 2; // i = 2 так как при первой итерации уже будет возведение числа в квадрат 
    int result = a;
    while(i <= b)
    {
        result = result * a;
        i++;
    }
    return result;
}
//{
//    for (int i = 2; i <= b; i++)
//    {
//        int result = a;
//        result = result * a;
//    }
//}

Console.WriteLine("Введите число которое нужно возвести в степень?");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В какую степень нужно возвести число {a}?");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {a} в степени {b} = {DegreeAByB(a, b)}");