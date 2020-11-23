using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201123
{
    struct Ember
    {
        public string Nev;
        public int Kor;

        public Ember(string n, int k)
        {
            Nev = n;
            Kor = k;
        }
    }

    struct Termek
    {
        public string Nev;
        public int Egysegar;
        public int Keszlet;
        public string Szallito;

        public Termek(string nev, int egysegar, int keszlet, string szallito)
        {
            Nev = nev;
            Egysegar = egysegar;
            Keszlet = keszlet;
            Szallito = szallito;
        }
    }

    class Program
    {
        static void Main()
        {
            //var termek1 = Beker(1);
            //var termek2 = Beker(2);
            //Feladat01(termek1, termek2);
            //Feladat02(termek1, termek2);
            //Feladat03(termek1, termek2);


            var termekek = new Termek[5];

            for (int i = 0; i < termekek.Length; i++)
            {
                termekek[i] = Beker(i);
            }

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            Console.ReadKey();
        }

        private static void Feladat03(Termek termek1, Termek termek2)
        {
            if(termek1.Szallito == termek2.Szallito)
                Console.WriteLine($"A(z) {termek1.Nev} és a(z) {termek2.Nev} beszéllítója ugyan az");
            else
                Console.WriteLine($"A(z) {termek1.Nev} és a(z) {termek2.Nev} beszéllítója NEM ugyan az");

        }

        private static void Feladat02(Termek termek1, Termek termek2)
        {
            if (termek1.Keszlet < 5) 
                Console.WriteLine($"A {termek1.Nev}-ből már csak {termek1.Keszlet} van, rendelni kell!");
            if (termek2.Keszlet < 5)
                Console.WriteLine($"A {termek2.Nev}-ből már csak {termek2.Keszlet} van, rendelni kell!");
        }

        static void Geza()
        {
            var e1 = new Ember();
            e1.Nev = "Géza";
            e1.Kor = 16;

            var e2 = new Ember()
            {
                Nev = "Géza",
                Kor = 16,
            };
            var e3 = new Ember("Géza", 16);

            Console.WriteLine($"{e3.Nev} {e3.Kor} éves");
            e3.Kor++;
            Console.WriteLine($"{e3.Nev} mostmár {e3.Kor} éves");
        }

        static Termek Beker(int num)
        {
            Console.WriteLine($"Adja meg a {num}. termék adatait: ");
            Console.Write("\tNév: ");
            var n = Console.ReadLine();
            Console.Write("\tEgységár: ");
            var e = int.Parse(Console.ReadLine());
            Console.Write("\tKészlet: ");
            var k = int.Parse(Console.ReadLine());
            Console.Write("\tSzállító: ");
            var sz = Console.ReadLine();

            return new Termek(n, e, k, sz);
        }

        static void Feladat01(Termek termek1, Termek termek2)
        {
            if (termek1.Egysegar > termek2.Egysegar)
            {
                Console.WriteLine($"A {termek1.Nev} a drágább {termek1.Egysegar - termek2.Egysegar} forinttal");
            }
            else if (termek1.Egysegar < termek2.Egysegar)
            {
                Console.WriteLine($"A {termek2.Nev} a drágább {termek2.Egysegar - termek1.Egysegar} forinttal");
            }
            else
            {
                Console.WriteLine($"A {termek1.Nev} és a {termek2.Nev} ára azonos");
            }

        }
    }
}
