using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Skladnik
    {
        private string nazwa;
        private int kalorie;
        public Skladnik(string anazwa, int akalorie)
        {
            this.nazwa = anazwa;
            this.kalorie = akalorie;
        }
    }
    class Salatka
    {
        Skladnik s1;
        Skladnik s2;
        Skladnik s3;

        public void przygotuj()
        {
            Skladnik s = new Skladnik("marchew", 60);
            if (this.s1 == null) this.s1 = s;
            Console.WriteLine("Przygotowuję...");
        }
        public void wydaj()
        {
            Console.WriteLine("Wydaję...");
        }
    }
    class Danie
    {
        private string zupa;
        private string napoj;
        private Salatka salatka;
        public void przyrzadzSalatke(Salatka asalatka)
        {
            this.salatka = asalatka;
            Console.WriteLine("Przyrządzam...");
        }
        public void zjedz()
        {
            Console.WriteLine("Jem...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Danie d = new Danie();
            Salatka s = new Salatka();
            s.przygotuj();
            d.przyrzadzSalatke(s);
        }
    }
}
