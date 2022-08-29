Console.WriteLine("Введите пороговое число: ");
int EndNum = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= EndNum; i++)
    Console.Write(Math.Pow(i, 3) + " ");