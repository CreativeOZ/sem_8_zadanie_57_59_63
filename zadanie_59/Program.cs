// 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

int[,] array = new int[2, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int sum = 0;
int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    Console.WriteLine($"Сумма строки {i + 1} = {sum}");
    if (i == 0)
    {
        result = sum;
    }
    else
    {
        if (sum < result)
        {
            result = sum;
            i = i + 1;
        }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {i}");
    }
}