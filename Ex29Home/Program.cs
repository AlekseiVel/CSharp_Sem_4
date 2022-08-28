// Напишите программу, которая задает массив из 8 элементов и 
// выводит их на экран 

Console.Clear();

int[] RandomNumbersArray(int size)
{
    int[] numbersArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Вводите элементы массива: ");
        numbersArray[i] = int.Parse(Console.ReadLine()!);
    }
    return numbersArray;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите размер массива?");
int size = int.Parse(Console.ReadLine()!);
int[] array = RandomNumbersArray(size);
PrintArray(array);
