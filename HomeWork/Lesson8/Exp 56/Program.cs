double[,] Create2DArray(int countRows, int countColumns)
{
    double[,] Array = new double[countRows, countColumns];
    Random Rand = new Random();
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            Array[i, j] = Rand.Next(1, 10);
        }
    }
    return Array;
}
void PrintArray(double[,] Array)
{
    //Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MinRowFromArray(double[,] Array)
{
    int CountRows = Array.GetLength(0);
    int CountColumns = Array.GetLength(1);
    //double[] y = new double[CountColumns];

    double minSum = 0;
    int minSumIndexRow = 0;

    for (int i = 0; i < CountRows; i++)
    {
        double SumRow = 0;
        for (int j = 0; j < CountColumns; j++)
        {
            SumRow += Array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки {SumRow}");
        if (i == 0)
        {
            minSum = SumRow;
            minSumIndexRow = i;
        }
        else
        {
            if (minSum > SumRow)
            {
                minSum = SumRow;
                minSumIndexRow = i;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой под номером {minSumIndexRow + 1}");
}
void Main()
{
    double[,] Array = Create2DArray(5, 2);
    Console.WriteLine("Вывод созданного массива:");
    PrintArray(Array);
    MinRowFromArray(Array);
}
Main();