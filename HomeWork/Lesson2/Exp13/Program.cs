Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
if( x >= 100) {
    int y = x % 10;
    Console.Write($"Третьим числом в {x} является {y}");
} 
else {
    Console.Write($"Длина числа менее 3 знаков");
}