int x = new Random().Next(100, 700);
Console.WriteLine($"Число {x}");
int y = Convert.ToInt32(x.ToString().Substring(0,1) + (x % 10));
Console.Write(y);


