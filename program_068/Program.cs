// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int FuncA(int n, int m)
{
  if (n == 0) return m + 1;
  else{
    if ((n != 0) && (m == 0)) return FuncA(n - 1, 1);
    else return FuncA(n - 1, FuncA(n, m - 1));
  }
}

Random random = new Random();
int m = random.Next(3);
int n = random.Next(3);

System.Console.Write($"m - {m}, n - {n} -> ");
System.Console.WriteLine(FuncA(m,n));