using System;

namespace PetraSkrlec
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
        }

        /// <summary>
        /// ZADATAK 4
        /// Zatraziti od korisnika unos sve dok ne unese troznamenkasti broj, ukoliko ne unese troznamenkasti broj ispisati "Pogrešan unos".
        /// Provjeriti je li uneseni broj veci ili jednak 500, ispisati rezultat provjere.
        /// </summary>
        private static void Zadatak4()
        {
            int brojZaProvjeru = 0;
            do
            {
                Console.WriteLine("Upišite broj: ");
                brojZaProvjeru = Convert.ToInt32(Console.ReadLine());

                if (brojZaProvjeru > 99 && brojZaProvjeru < 1000)
                {
                    if (brojZaProvjeru >= 500)
                    {
                        Console.WriteLine("Broj je veci ili jednak 500.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Broj je manji od 500");
                        break;
                    }
                }
            } while (true);
            Console.ReadKey();
        }

        /// <summary>
        /// ZADATAK3
        /// Napisite funkciju koja kao parametar prima broj i provjerava je li taj broj djeljiv s 3.
        /// Funkcija vraca boolean, od korisnika zatraziti unos broja, prosljediti u funkciju i ispisati rezultat pozivanja funkcije.
        /// </summary>
        private static void Zadatak3()
        {
            Console.WriteLine("Upišite prvi broj: ");
            int brojZaProvjeru = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rezultat pozivanja funkcije je " + Provjera(brojZaProvjeru));

            Console.ReadKey();
        }

        private static bool Provjera(int broj)
        {
            if (broj % 3 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// ZADATAK 2
        /// Zatraziti od korinsnika unos dva broja. Pronaci koji je od ta dva broja manji, ukoliko je razlika brojeva veca od 5, ispisi 
        /// njihov zbroj, inace ispisi njihovu razliku, ako je razlika ista, ispisi "unesena su dva ista broja."
        /// </summary>
        private static void Zadatak2()
        {
            Console.WriteLine("Upišite prvi broj: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upišite drugi broj: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Unesena su dva ista broja.");
            }
            else if (a < b)
            {
                if (b - a > 5)
                {
                    Console.WriteLine("Njihov zbroj je " + (a + b));
                }
                else
                {
                    Console.WriteLine("Njihova razlika je " + (b - a));
                }
            }
            else
            {
                if (a - b > 5)
                {
                    Console.WriteLine("Njihov zbroj je " + (a + b));
                }
                else
                {
                    Console.WriteLine("Njihova razlika je " + (a - b));
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// ZADATAK 1
        /// Zatrazite od korisnika unos dvije stranice pravokutnika a i b,
        /// i izracunaj povrsinu pravokutnika u varijablu P te rezultat ispisi korisniku
        /// </summary>
        private static void Zadatak1()
        {
            Console.WriteLine("Upisite stranicu A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int p = a * b;

            Console.WriteLine("Površina pravokutnika je p=" + p);
            Console.ReadKey();
        }
    }
}