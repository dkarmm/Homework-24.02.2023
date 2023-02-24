// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetArraySize()
{
    Console.Write("Введите размер вашего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void AddNumbersInArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 100);
    }
}

void ShowArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}

int FindMin(int[] array)
{
    int min = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min) min = array[index];
    }
    return min;
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) max = array[index];
    }
    return max;
}

int[] array = new int[GetArraySize()];
if (array.Length == 0)
{
    Console.WriteLine("Массив пуст.");
    return;
}

AddNumbersInArray(array);
ShowArray(array);

Console.WriteLine($"Наибольшее число: {FindMax(array)}, наименьшее: {FindMin(array)}");
Console.WriteLine($"Их разница равна: {FindMax(array) - FindMin(array)}");

