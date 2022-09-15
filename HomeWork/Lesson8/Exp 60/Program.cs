double[,,] Create3DArray(int x, int y, int z)
{
    double[,,] Array = new double[x, y, z];
    Random Rand = new Random();
    double[] ArrayRandomNumbers = new double[x*y*z];
    for(int i = 0; i < x*y*z; i++){
        double Rnd = Rand.Next(10, 100);
        int j = 0;
        while(j < x*y*z){
            if(ArrayRandomNumbers[j] == Rnd){
                Rnd = Rand.Next(10, 100);
                j = 0;
            }else j++;
        }
        ArrayRandomNumbers[i] = Rnd;
        //Console.WriteLine(Rnd);
    }
    int a = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int n = 0; n < z; n++)
            {
              
                Array[i, j, n] = ArrayRandomNumbers[a];
                a++;
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