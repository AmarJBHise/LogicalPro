using System.Reflection.PortableExecutable;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palindrome();
            PrimeNumber();
        }

        public static void Palindrome()// Palindrome number programe
        {
            int a, b, c = 0, temp;
            Console.Write("Please Enter the Number.... ");
            a = Convert.ToInt32(Console.ReadLine());
            temp = a;
            while (a > 0)
            {
                b = a % 10;
                c = (c * 10) + b;
                a = a / 10;
            }
            if (temp == c)
            {
                Console.Write("Number is Palindrome.");
            }
            else
            {
                Console.Write("Number is not Palindrome.");
            }
        }

        public static void PrimeNumber()// Prime Number
        {
            int e, f, g, h = 0;

            Console.Write("Please Enter the Number....  ");
        
            e = Convert.ToInt32(Console.ReadLine());

            g = e / 2;

            for (f = 2; f <= g; f++)
            {
                if (e % f == 0)
                {
                    Console.Write("Number is not Prime.");
                    h = 1;
                    break;
                }
            }
            if (h == 0)
            {
                Console.Write("Number is Prime.");
            }

        }
    }
}
    
