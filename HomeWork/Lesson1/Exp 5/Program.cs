Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = - x;
string y = "";
while ( i <= x){
    y += Convert.ToString(i) + ',';
    i++;
}
Console.Write(y.Substring(0, y.Length - 1));
