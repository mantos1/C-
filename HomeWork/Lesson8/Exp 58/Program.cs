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
void MatrixMultiplication(double[,] Matrix1, double[,] Matrix2)
{
    int CountRowsMatrix1 = Matrix1.GetLength(0);
    int CountColumnsMatrix1 = Matrix1.GetLength(1);
    int CountRowsMatrix2 = Matrix2.GetLength(0);
    int CountColumnsMatrix2 = Matrix2.GetLength(1);
    
    if(CountRowsMatrix1 == CountColumnsMatrix2) {
        double[,] MatrixMultiplication = new double[CountRowsMatrix1,CountColumnsMatrix2];

        for (int i = 0; i < CountRowsMatrix1; i++)
        {
            //Console.WriteLine($"{i+1} проход"); 
            for (int a = 0; a < CountColumnsMatrix2; a++)
            {              
                double SumMultiplication = 0;   
                for (int j = 0; j < CountColumnsMatrix1; j++)
                { 
                        SumMultiplication += Matrix1[i,j] * Matrix2[j,a];            
                        //Console.WriteLine($"{Matrix1[i,j]} * {Matrix2[j,a]}");
                        //Console.WriteLine(SumMultiplication);
                }
            MatrixMultiplication[i,a] = SumMultiplication;
            }                 
        }  
        Console.WriteLine("Произведение матриц равно: ");           
        PrintArray(MatrixMultiplication);
    } 
    else Console.Write("Невозможно перемоножить указанные матрицы, т.к. кол-во строк 1 матрицы не воспадает с кол-вом столбцов 2 матрицы!");
}
void Main()
{
    double[,] Array = Create2DArray(2, 3);
    Console.WriteLine("Вывод созданной матрицы:");
    PrintArray(Array);
    double[,] Array2 = Create2DArray(3, 2);
    Console.WriteLine("Вывод созданной матрицы:");
    PrintArray(Array2);
    MatrixMultiplication(Array,Array2);
}
Main();