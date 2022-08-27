Console.WriteLine("Введите трехзначное значное число");
int x = Convert.ToInt32(Console.ReadLine());
string y = Convert.ToString(x);
if( y.Length == 3){
    //Console.WriteLine(y.Substring(2,1));
    Console.WriteLine(x % 10);
}
else {
    Console.WriteLine("Указано не трехзначное чиcло");
}

