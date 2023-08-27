int Accerman(int m, int n){
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Accerman(m -1 , 1);
    else  return Accerman(m -1 , Accerman(m, n - 1));
    
}

Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int k = Accerman(m, n);
Console.WriteLine(k);