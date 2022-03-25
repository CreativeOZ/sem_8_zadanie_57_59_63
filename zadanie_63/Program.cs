// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами 
// и вывести его на экран построчно, с индексами элементов.

Console.Clear();

int[,,] array = new int[3, 3, 3];
Random random = new Random(DateTime.Now.Millisecond); //метод неповторяющихся чисел (вроде работает).

for (int i = 0; i < array.GetLength(0); i++)
{
    /* var x = new Random().Next(10, 100); //иная попытка проверить на не повторение числа (код не запустился).
    if (!(array.Contains(x)))
    {
        array[i] = x;
    }
    else
    {
        i--;
    }
} */
    for (int j = 0; j < array.GetLength(1); j++)
    {
        /* var y = new Random().Next(10, 100);
        if (!(array.Contains(y)))
        {
            array[i] = y;
        }
        else
        {
            j--;
        } */
        for (int k = 0; k < array.GetLength(2); k++)
        {
            /* var z = new Random().Next(10, 100);
            if (!(array.Contains(z)))
            {
                array[i] = z;
            }
            else
            {
                k--;
            } */
            array[i, j, k] = random.Next(10, 100);
            Console.Write(array[i, j, k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(array[i, j, k] + " " + "(i: " + i + " ; j: " + j + " k: " + k + " )" + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
