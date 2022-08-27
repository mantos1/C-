Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = x % 100 / 10;
Console.Write($"Вторым числом в {x} является {y}");