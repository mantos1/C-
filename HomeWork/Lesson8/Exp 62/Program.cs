int[,] Create2DArray(int countRows, int countColumns)
{

    int[,] Array = new int[countRows, countColumns];
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= countRows * countColumns)
    {
        Array[i,j] = k;
        
        if (i == Ibeg && j < countColumns - Jfin - 1)
            ++j;
        else if (j == countColumns - Jfin - 1 && i < countRows - Ifin - 1)
            ++i;
        else if (i == countRows - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;
        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != countColumns - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    return Array;
}
void PrintArray(int[,] Array)
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
void Main()
{
    int[,] Array = Create2DArray(4, 4);
    Console.WriteLine("Вывод созданной матрицы:");
    PrintArray(Array);
}
Main();