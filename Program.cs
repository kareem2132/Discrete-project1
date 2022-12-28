using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter n1: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter n2: ");
                int n2 = int.Parse(Console.ReadLine());

             for (int i = n1; i <= n2; i++)
             {
                  if (IsPrime(i))
                  {
                    Console.Write(i + " ");
                  }
             }
        }

         static bool IsPrime(int n)
         {
              if (n < 2)
              {
                return false;
              }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
             return true;
         }
    }
}
