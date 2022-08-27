Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = 0;
string y = "";
while( i <= x){
    if(i != 0){
        y += Convert.ToString(i) + ',';
    }
    i += 2;
}
Console.Write(y.Substring(0, y.Length - 1));