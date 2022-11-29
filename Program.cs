//  Задача 54
int[,] arr = {  { 1, 4, 8, 2 },
                { 5, 9, 2, 3 },
                { 8, 4, 2, 4 }  };

SortArray(arr);

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k <= arr.GetLength(0); k++)
            {
                if (arr[i, k] > arr[i, max]) max = k;
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, max];
            arr[i, max] = temp;
        }
    }
}

PrintArray(arr);

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
}



//  Задача 56
int[,] array = { { 1, 9, 1 },
                 { 1, 8, 1 },
                 { 1, 7, 1 } };

Console.WriteLine(SmallString(array));

string SmallString(int[,] array)
{
    int proverka = 0;
    int minLine = 0;
    int[] line = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }

        line[i] = sum;

        if (line[i] < line[minLine]) minLine = i;
        if (line[i] == line[minLine]) proverka++;


    }
    if (proverka == array.GetLength(0) + 1) return "Все строки равны";
    else return $"Строка с наименьшей суммой {minLine + 1}";
}
