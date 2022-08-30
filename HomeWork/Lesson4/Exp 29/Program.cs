string GetArray(string[] array){
    string Result = "";
    foreach(var i in array){
        Result += "," + i;         
    }
    return "[" + Result.Substring(1,Result.Length - 1) + "]";
}

string[] array = new string[8];
Console.WriteLine("Введите значения через запятую");
array = Convert.ToString(Console.ReadLine()).Split(new[] {','});
Console.WriteLine(GetArray(array)); 

