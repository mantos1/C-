double[,] Create2DArray(int countRows, int countColumns)
{
    double[,] Array = new double[countRows, countColumns];
    Random Rand = new Random();
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            Array[i, j] = Math.Round(Rand.NextDouble() * Rand.Next(-1000, 1000), 1);
        }
    }
    return Array;
}
void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Main()
{
    Console.WriteLine("Введите размер двумерного массива через пробел: ");
    string[] ParamArray = Convert.ToString(Console.ReadLine()).Split(new[] { ' ' });
    PrintArray(Create2DArray(int.Parse(ParamArray[0]), int.Parse(ParamArray[1])));
}
Main();