using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Herbata
    {
        public string krajPochodzenia;
        public string nazwa;
        public string aromat;
        public void sparz()
        {
            Console.WriteLine("Parzę...");
        }
    }
    class Termos
    {
        public int pojemnosc;
        public int waga;
        public int cena;
        public string zawartosc;
        private Herbata herbata;
        public Termos(Herbata aherbata)
        {
            this.herbata = aherbata;
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
            Termos t1 = new Termos(h1);
        }
    }
}
