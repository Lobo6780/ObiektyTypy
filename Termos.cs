using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Herbata
    {
        private string krajPochodzenia;
        private string nazwa;
        private string aromat;

        /* tego nie używać
        public string Aromat
        {
            get
            {
                return aromat;
            }
            set
            {
                aromat = value;
            }
        }
        */

        //hermetyzacja
        public string getkrajPochodzenia()
        {
            return krajPochodzenia;
        }
        public void setkrajPochodzenia(string kraj)
        {
            this.krajPochodzenia = kraj;
        }
        public void sparz()
        {
            Console.WriteLine("Parzę...");
        }
    }
    class Termos
    {
        private int pojemnosc;
        private int waga;
        private double cena;
        public Herbata zawartosc;

        //hermetyzacja
        public void setPojemnosc(int poj)
        {
            this.pojemnosc = poj;
        }
        public int getPojemnosc()
        {
            return this.pojemnosc;
        }
        public void setWaga(int wag)
        {
            this.waga = wag;
        }
        public int getWaga()
        {
            return this.waga;
        }
        public void setCena(double cen)
        {
            this.cena = cen;
        }
        public double getCena()
        {
            return this.cena;
        }
        public Termos(Herbata aherbata)
        {
            this.zawartosc = aherbata;
        }
        public void polej()
        {
            Console.WriteLine("Leję...");
        }
        public void umyj()
        {
            Console.WriteLine("Myję...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Herbata h1 = new Herbata();
            h1.setkrajPochodzenia("Kolumbia");
            Termos t1 = new Termos(h1);
            Console.WriteLine(h1.getkrajPochodzenia());
        }
    }
}
