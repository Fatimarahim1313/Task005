// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();
int oddSumm = 0;
int[] array = new int[5];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100);
    if (i % 2 == 1)
    {
        oddSumm += array[i];
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
Console.WriteLine($"] -> {oddSumm}");