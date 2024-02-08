//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
{
if (m == 0)
            return n + 1;
        else if (n == 0)
           return Ackermann(m - 1, 1);
        else
           return Ackermann(m - 1, Ackermann(m, n - 1));
   }

    static void Main()
    {
int m = 2;
int n = 3;

        result = Ackermann(m, n);
       Console.WriteLine("Результат функции Аккермана для m={0} и n={1}: {2}", m, n, result);
   }
}
