// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N. 
//рекурсию, не использовать циклы.

//using System;

//class Program
//{
  //  static void PrintRange(int m, int n)
   // {
     //   if (m > n)
       //     return;
        
        //Console.WriteLine(m);
        //PrintRange(m + 1, n);
    //}

    //static void Main()
    //{
      //  int m = 1;
       // int n = 10;
       //PrintRange(m, n);
   // }
//}

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//using System;

//class Program
//{
    //static int Ackermann(int m, int n)
//{
//if (m == 0)
            //return n + 1;
        //else if (n == 0)
           // return Ackermann(m - 1, 1);
        //else
           // return Ackermann(m - 1, Ackermann(m, n - 1));
   // }

    //static void Main()
    //{
//int m = 2;
//int n = 3;

        // result = Ackermann(m, n);
       // Console.WriteLine("Результат функции Аккермана для m={0} и n={1}: {2}", m, n, result);
   // }
//}

//Задача 3: Задайте произвольный массив. 
 //его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int lastIndex = array.Length - 1;

        PrintArrayReverse(array, lastIndex);
    }
}
git remote add origin https://github.com/agafapudova/-.git