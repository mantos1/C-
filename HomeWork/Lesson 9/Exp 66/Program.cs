int RecursiveSumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + RecursiveSumNumbers(++m, n);
}
void Main()
{
    Console.WriteLine("Введите начальное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if(m <= n && m > 0 && n > 0)
        Console.Write($"Сумма всех натуральных чисел в диапазоне {m} : {n} равна {RecursiveSumNumbers(m, n)}");
    else  Console.WriteLine("Не корректные вводные!");
}
Main();