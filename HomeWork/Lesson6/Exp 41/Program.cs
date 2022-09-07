int[] ArrayNumbers = new int[10000000];
int Result = 0;

int GetNumbers()
{
    int i = 0;
    int a = 0;
    int a_print = 0;
    string value_ = string.Empty;    
    while (i < 1)
    {
        a_print = a + 1;
        if (a == 0) {Console.Write($"Введите {a_print} число: ");}
        else {Console.Write($"Введите {a_print} число или для запуска вычисления введите 'go': ");}        
        value_ = Console.ReadLine();
        if (value_ == "go") break;
        else ArrayNumbers[a] = Convert.ToInt32(value_);
        a++;
    }
    a_print--;
    return a_print;
}

int CountNumbers(int MaxArrayCount) {    
    for(int i = 0; i < MaxArrayCount; i++){
        if(ArrayNumbers[i] > 0) Result++;        
    }
    return Result;
}

void PrintResult (int Result){
    Console.Write(Result);
}

void Main(){
    int MaxArrayCount = GetNumbers(); 
    PrintResult(CountNumbers(MaxArrayCount));
}

Main();