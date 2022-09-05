int Count(string a){
    int Result = 0;
    foreach(var i in a){  
        if (Convert.ToInt32(Convert.ToString(i))%2==0)
            Result++; 
    } 
    return Result;
}

Console.WriteLine("Введите число: ");
Console.WriteLine(Count(Console.ReadLine()));

 