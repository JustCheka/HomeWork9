void ShowNum(int m, int n){
    if (m >= n) {
        return ;
    }

    if (m % 2 == 0) Console.Write(m + " ");
    ShowNum(m + 1, n);
}

Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

ShowNum(m,n);