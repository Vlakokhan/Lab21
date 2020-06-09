using System;

namespace Lab21
{
    public class Program
    {
        public static string Number(int number)
        {
            string c;
            switch (number)
            {
                case 1:
                    c = "червоний";
                    break;
                case 2:
                    c = "помаранчевий";
                    break;
                case 3:
                    c = "жовтий";
                    break;
                case 4:
                    c = "зелений";
                    break;
                case 5:
                    c = "блакитний";
                    break;
                case 6:
                    c = "синiй";
                    break;
                case 7:
                    c = "фiолетовий";
                    break;
                default:
                    c = "Невiрне значення";
                    break;
            
            }

            return c;

        }

        static void Main()
        {
            string c;
            Console.Write("Введіть номер кольору (від 1 до 7 ): ");
            int number = Convert.ToInt32(Console.ReadLine());
            c = Number(number);
            Console.WriteLine(c);
        }
    }
} 
