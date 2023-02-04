// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.Clear();
Console.Write("Fill in the first number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Fill in the second number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(A(n, m));