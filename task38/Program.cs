//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Random rnd = new Random();
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
}
int max = array[0], min = array[0];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
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
int result = max - min;
Console.WriteLine($"] -> {result}");