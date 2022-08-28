// Напишите программу, которая выводит массив из 8 эелемнтов,
// заполненный нулями и единицами в случайном порядке.

Console.Clear();

//Функция выдачи случайного числа
//int RandomNumber()
//{
//    int randomN = new Random().Next(0,1);
//    return randomN;
//}

int[] RandomNumbersArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random(); 
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next(2); //равносильно rnd.Next[0,1] или rnd.Next(0,2)
    }
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива?");
int size = int.Parse(Console.ReadLine()!);
int[] array = RandomNumbersArray(size);
PrintArray(array);
