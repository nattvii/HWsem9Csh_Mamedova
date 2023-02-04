// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

int sum(int n, int m)
{
    return (m + n)*(m - n + 1)/2;
}

Console.Clear();
Console.Write("Fill in the first number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Fill in the second number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(n, m));