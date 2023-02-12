System.Console.Write("Задайте значение (N) >>> ");

int n = Convert.ToInt32(Console.ReadLine());

int m = 1;

Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}