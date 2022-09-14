/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
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
double[,] SortArray(double[,] Array)
{
    int CountRows = Array.GetLength(0);
    int CountColumns = Array.GetLength(1);
    //double[] y = new double[CountColumns];

    for (int i = 0; i < CountRows; i++)
    {
        double[] new1DArray = new double[CountColumns];
        for (int j = 0; j < CountColumns; j++)
        {
            new1DArray[j] = Array[i, j];
        }

        double[] new1DArray2 = new1DArray.OrderByDescending(x => x).ToArray();

        for (int j = 0; j < CountColumns; j++)
        {
            Array[i, j] = new1DArray2[j];
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
void Main()
{
    double[,] Array = Create2DArray(5, 5);
    Console.WriteLine("Вывод созданного массива:");
    PrintArray(Array);
    Console.WriteLine("Вывод отсортированного массива:");
    PrintArray(SortArray(Array));
}
Main();