using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç sayısını giriniz: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş sayısını giriniz: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir sayı girin (0) bulana kadar / (0> yazdığınız sayı kadar): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            int number = rand.Next(num1, num2);

            find(n, number);

            static int find(int n, int rand)
            {
                bool loop = true;
                if (n == 0)
                {
                    while (loop)
                    {
                        Console.Write("Tahmin ediniz: ");
                        int g = Convert.ToInt32(Console.ReadLine());
                        if (g == rand)
                        {
                            loop = false;
                            Console.Write("Tebrikler");
                        }
                        else
                        {
                            if (g > rand)
                            {
                                Console.WriteLine("Aşağı");
                            }
                            else
                            {
                                Console.WriteLine("Yukarı");
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Tahmin ediniz: ");
                        int g = Convert.ToInt32(Console.ReadLine());
                        if (g == rand)
                        {
                            Console.WriteLine("Tebrikler");
                            break;
                        }
                        else if (g > rand)
                        {
                            Console.WriteLine("Aşağı");
                        }
                        else
                        {
                            Console.WriteLine("Yukarı");
                        }
                    }
                }

                return 0;
            }
            Console.ReadKey();
        }
    }
}
