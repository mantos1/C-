double[,] Create2DArray(int countRows, int countColumns)
{
    int ParamForRandom = 0;
    double[,] Array = new double[countRows, countColumns];
    Random Rand = new Random();
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            ParamForRandom = Rand.Next(0, 100);
            if (ParamForRandom % 2 == 0) Array[i, j] = Math.Round(Rand.NextDouble() * Rand.Next(-1000, 1000), 1);
            else Array[i, j] = Rand.Next(-1000, 1000);
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
void SearchAndPrintValue(double[,] Array)
{
    Console.WriteLine("Введите позицию числа: ");
    string[] ParamArray = Convert.ToString(Console.ReadLine()).Split(new[] { ' ' });
    int x = int.Parse(ParamArray[0]);
    int y = int.Parse(ParamArray[1]);
    bool isSeached = false;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (isSeached == false)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if (isSeached == false)
                {
                    if (x == i && y == j)
                    {
                        Console.Write($"Число с указанной позицией [{x},{y}] найдено: {Array[i, j]}.");
                        isSeached = true;
                    }
                }
                else break;
            }            
        }
        else break;
    }
    if (isSeached == false) Console.WriteLine($"Число с указанной позицией [{x},{y}] не найдено.");    
}
void Main()
{
    Random Rand = new Random();
    double[,] Array = Create2DArray(Rand.Next(1, 5), Rand.Next(1, 10));
    PrintArray(Array);
    SearchAndPrintValue(Array);
}
Main();