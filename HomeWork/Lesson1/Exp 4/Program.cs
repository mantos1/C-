Console.WriteLine("Укажите первое значение:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите второе значение:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите третье значение:");
int c = int.Parse(Console.ReadLine());
if( a > b) {
    if(a > c){
        Console.WriteLine("Max = " + a);    
    }
    else {
        Console.WriteLine("Max = " + c);
    }
} 
else {
    if(b > c){
        Console.WriteLine("Max = " + b);    
    }
    else {
        Console.WriteLine("Max = " + c);
    }
}

