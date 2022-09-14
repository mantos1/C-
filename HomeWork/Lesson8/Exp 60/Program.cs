double[,,] Create3DArray(int x, int y, int z)
{
    double[,,] Array = new double[x, y, z];
    Random Rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
                Array[i, j, n] = Rand.Next(1, 10);
            }
        }
    }
    return Array;
}
void PrintArray(double[,,] Array)
{
    //Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int n = 0; n < Array.GetLength(2); n++)
            {
                Console.Write($"{Array[i, j, n]} ({i},{j},{n}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Main()
{
    double[,,] Array = Create3DArray(2, 2, 2);
    Console.WriteLine("Вывод массива:");
    PrintArray(Array); 
}
Main();