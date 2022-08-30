int NumPow (int a, int b) {
    int c = a;
    for(int i = 1; i <= b - 1; i++) {        
        a = a * c; 
    }
    return a;
}
Console.WriteLine("Введите два числа через запятую: ");
var Arr = Convert.ToString(Console.ReadLine()).Split(new[] {','});
int Result = NumPow(Convert.ToInt32(Arr[0]), Convert.ToInt32(Arr[1]));
Console.Write(Result);