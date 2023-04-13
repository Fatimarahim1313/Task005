// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int evenCount = 0;
int[] array = new int[5];
FillArray(array);
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
    //Для красивого вывода
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}");
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
}
Console.WriteLine($"] -> {evenCount}");

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
}