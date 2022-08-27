Console.WriteLine("Укажите число");
int x = Convert.ToInt32(Console.ReadLine());
int a = x % 2;
if (a == 0){
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}