int SumOfNum(int m, int n){
    if (m == n) return m;
    return m + SumOfNum(m + 1, n);
}

Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int k = SumOfNum(m,n);
Console.WriteLine(k);