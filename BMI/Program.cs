using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double váha;
            double výška;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Výpočet BMI");
                Console.WriteLine("-------------------------------");
                {
                    Console.Write("Zadej svou hmotnost (Kg)=");
                    double.TryParse(Console.ReadLine(), out váha);
                    if (váha <= 0)
                    {
                        Console.WriteLine("Pouze přirozená čísla");
                    }
                    double.TryParse(Console.ReadLine(), out výška);
                    if (výška <= 0)
                    {
                        Console.WriteLine("Pouze přirozená čísla");
                    }
                    else
                    {
                        Console.WriteLine("Zadej svou výšku (m)=");
                        výška = double.Parse(Console.ReadLine());

                        var BMI = váha/výška*výška
                    }
                }
            
            }
        }
    }
