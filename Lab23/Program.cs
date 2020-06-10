using System;

namespace Lab23
{
public class Program
        {
            public static int Product(int mult, int[] mass)
            {
            
                for(int i=0;i< mass.Length; i++)
                {
                    if (mass[i] > 0)
                        mult *= mass[i];
                }
                return mult;
            }

            public static int Sum(int[] mass, int k, int sum)
            {
                for (int i = 0; i < k; i++)
                    sum += mass[i];
                return sum;
            }
            static void Main(string[] args)
            {
                int mult = 1;
                Console.Write("Введiть кiлькiсть елементiв масиву:\t ");
                int number = int.Parse(Console.ReadLine());
                int[] mass = new int[number];
               
               
                
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"Введiть елемент массиву под iндексом {i}:\t");
                    mass[i] = int.Parse(Console.ReadLine());
                    
                }

                Console.WriteLine("Виводимо масив:");
                for (int i = 0; i < mass.Length; i++) 
                {
                    Console.WriteLine(mass[i]);
                }

                mult = Product(mult, mass);
                Console.WriteLine("Добуток додатнiх елементiв массиву=" + mult);
                int sum = 0,elem=0,k=0;
                for(int i = 0; i < mass.Length; i++)
                    if(mass[i]>0)
                    {
                        elem = mass[i];
                        k = i;
                    }
                if (elem <= 0) Console.WriteLine("Додатньiнiх елементiв в массивi немає!");
                else Console.WriteLine("Останній  елемент в масивi: " + elem);
                sum = Sum(mass, k, sum);
                Console.WriteLine("Сумa елементiв масиву, розташованих до останнього додатного елементa: " + sum);
                Console.ReadKey();

            }
        }
    }