double[,] Params = new double[2, 2];
double[] Intersect = new double[2];

void GetParams()
{
    int count = 0;
    for (int i = 0; i < Params.GetLength(0); i++)
    {
        count = i + 1;
        Console.WriteLine($"Введите переменные для {count} уравнения y = k{count} * x + b{count}");
        for (int j = 0; j < Params.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Переменная b{count}: ");
            }
            else
            {
                Console.Write($"Переменная k{count}: ");
            }
            Params[i, j] = Convert.ToDouble(Console.ReadLine());
        }
    }    
}

double[] GetСalculation(double[,] ArrayParams){
  Intersect[0] = (ArrayParams[0,0] - ArrayParams[1,0]) / (ArrayParams[1,1] - ArrayParams[0,1]);
  Intersect[1] = ArrayParams[0,1] * Intersect[0] + ArrayParams[0,0];
  return Intersect;
}

void GetPrint() {
  double[] Result = new double[2];
  Result = GetСalculation(Params);
  Console.WriteLine("Точка пересечения [{0}]", string.Join(",", Result));
}

void Main(){
  int i = 0;
  GetParams();
  while( i < 1){
    if(Params[0,0] == Params[1,0] && Params[0,1] == Params[1,1]){
      Console.WriteLine("Прямые совпадают");
      break;
    }
    else if(Params[0,0] != Params[1,0] && Params[0,1] == Params[1,1]){    
      Console.WriteLine("Прямые параллельны");
      break;
    }
    else {
      GetPrint();
      break;    
    }
  }
}

Main();