
using System;

namespace lab2ex3
{
    /*  Să se scrie un program care citeşte de la tastatură un şir de n numere 
        naturale şi determină media aritmetică a celor pare, n fiind citit de la 
        tastatra
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numere sa contina sirul? ");
            int n = int.Parse(Console.ReadLine());
            int[] sirNumere = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul din pozitia {i} a sirului de numere: ");
                int num = int.Parse(Console.ReadLine());
                sirNumere[i] = num;
            }


            int sumaNumerePare = 0;
            double contorNumerePare = 0;

            for(int i = 0; i < n; i++)
            {
                if (sirNumere[i] % 2 == 0)
                {
                    sumaNumerePare = sumaNumerePare + sirNumere[i];
                    contorNumerePare++;
                }
            }

            Console.WriteLine($"Media aritmetica a celor {contorNumerePare} numere pare este {sumaNumerePare / contorNumerePare}");
        }
    }
}
