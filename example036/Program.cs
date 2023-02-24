// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[index] = new Random().Next(1, 101);
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

int GetSumFromArray (int [] array)
{
    int sum = 0;
    int index = 1;
    if (array.Length == 1)
    {
        return array[0];
    }
    else
    {
        while (index < array.Length)
        {
            sum = sum + array[index];
            index = index + 2;
        }
    }
    return sum;
}

int [] array = new int [GetArraySize()];
if (array.Length == 0)
{
    Console.WriteLine("Массив пуст.");
    return;
}

AddNumbersInArray(array);
ShowArray(array);

Console.WriteLine($"Сумма чисел на нечётной позиции равна: {GetSumFromArray(array)}.");