// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetArraySize ()
{
    Console.Write("Введите размер вашего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void AddNumbersInArray(int [] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
}

void ShowArray(int [] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}

int FindEvenNumbers(int [] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0) count++;
    }
    return count;
}

int [] array = new int [GetArraySize()];
if (array.Length == 0)
{
    Console.WriteLine("Массив пуст.");
    return;
}

AddNumbersInArray(array);
ShowArray(array);

Console.WriteLine($"Количество чётных чисел в массиве: {FindEvenNumbers(array)}");
