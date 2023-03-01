// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int funAcc(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return funAcc(n - 1, 1);
    else
        return funAcc(n - 1, funAcc(n, m - 1));
}
 
Console.WriteLine(funAcc(1, 2)); // 4
Console.WriteLine(funAcc(0, 0)); // 1

 