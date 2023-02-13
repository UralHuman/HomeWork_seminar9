System.Console.Write("Задайте значение (n) >>> ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Задайте значение (m) >>> ");
int m = Convert.ToInt32(Console.ReadLine());

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"{m}, {n} ->");

PrintSum(m, n, temp = 0);