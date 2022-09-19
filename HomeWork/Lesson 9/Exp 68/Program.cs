int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m,n);
}
void Main(){
    Console.WriteLine("Введите число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n");    
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ответ: {A(m, n)}"); 
}
Main();