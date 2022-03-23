// 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Колличество срок: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Колличество стобцов: ");
int n = int.Parse(Console.ReadLine());
int save = 0;
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = n - 1; k > j; k--)
        {
            if (array[i, k - 1] < array[i, k])
            {
                save = array[i, k];
                array[i, k] = array[i, k - 1];
                array[i, k - 1] = save;
            }
        }
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
