Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

PrintResult(FunAkk(n, m));

int FunAkk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return FunAkk(n - 1, 1);
    if (n > 0 && m > 0) return FunAkk(n - 1, FunAkk(n, m - 1));
    return FunAkk(n, m);
}

void PrintResult(int a)
{
    Console.WriteLine($"\nРезультат вычисления >>> {a}");
}

System.Console.WriteLine();