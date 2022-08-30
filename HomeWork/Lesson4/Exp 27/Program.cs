int Sum(string a){
    int Result = 0;
    foreach(var i in a){  
        Result = Result + Convert.ToInt32(Convert.ToString(i));  
    } 
    return Result;
}
Console.WriteLine("Введите число: ");
string x = Console.ReadLine();
int y = Sum(x);

Console.WriteLine(y);