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
    Console.WriteLine("Созданный массив: ");
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
double[] GetAvg(double[,] Array)
{
    int CountRows = Array.GetLength(0);
    int CountColumns = Array.GetLength(1);    
    double[] y = new double[CountColumns];
    for (int i = 0; i < CountColumns; i++)
    {
        double x = 0;
        for (int j = 0; j < CountRows; j++)
        {
            x += Array[j, i];
        }
        y[i] = Math.Round(x / CountRows, 1);
    }
    return y;
}
void PrintResult(double[] Array)
{
    foreach (double i in Array)
    {
        Console.Write(i + " ");
    }
}
void Main()
{
    Random Rand = new Random();
    double[,] Array = Create2DArray(Rand.Next(2, 5), Rand.Next(1, 10));
    PrintArray(Array);
    PrintResult(GetAvg(Array));
}
Main();