Console.WriteLine("Первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int y = Convert.ToInt32(Console.ReadLine());
int z = x % y; // остаток
if(z != 0){ // проверка  на остаток
    Console.Write($"Число {x} не кратно {y}, остаток {z}");
}
else {
    Console.Write($"Число {x} кратно {y}");
}