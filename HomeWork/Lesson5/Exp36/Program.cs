int[] GetArray(int Length)
{
    int[] Array = new int[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 10);
    }
    return Array;

}
int SumValue(int[] Array){
    int result = 0; 
    for (int i = 0;i < Array.Length; i++)
    {
        
        if ((i % 2) != 0) {
            Console.WriteLine($"число {Array[i]} имеет нечетный порядковый номер {i}");
            result = result + Array[i];
        } 
    }
     Console.WriteLine();
    return result;
}

int Length = 10;
int[] Array = new int[Length];
Array = GetArray(Length);
Console.WriteLine("Создан массив [{0}]", string.Join(",", Array));
Console.WriteLine();
Console.WriteLine($"Сумма чисел равна {SumValue(Array)}");
