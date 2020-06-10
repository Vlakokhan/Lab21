using System;

namespace Lab25B
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Розмiрнiсть матрицi:");
            int n, m;
            Console.Write("Кiлькiсть рядкiв:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n % 2 != 0)
            {
                Console.Write("Введiть парну кiлькiсть рядкiв:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Кiлькiсть стовпцiв:");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            int[,] B = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rand.Next(-100,100);
                }
            }
            Console.WriteLine("Показ матрицi:");
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.Write("\n");
            }

            int z = 0, x = 0;
            Console.WriteLine("Показ нової матрицi:");
            for (int i = n/2; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    B[z, x] = A[i, j];
                    x++;
                }
                x = 0;
                z++;
            }

            x = 0;
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j < m; j++)
                { 
                    B[z, x] = A[i, j];
                    x++;
                }
                x = 0;
                z++;
            }
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
} 
