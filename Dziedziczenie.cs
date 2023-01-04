using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Pojazd
    {
        private string nazwa;
        private string vin;
        
        public void jedz()
        {
            Console.WriteLine("Jadę");
        }
        public void tankuj()
        {
            Console.WriteLine("Tanktuję");
        }
    }
    class Samochod : Pojazd
    {
        private string oc;

        public void zaparkuj()
        {
            Console.WriteLine("Parkuję");
        }
    }
    class Motur : Pojazd
    {
        public void zalozKask()
        {
            Console.WriteLine("Zakładam");
        }
    }
    class Koparka : Pojazd
    {
        private string udt;
        
        public void kop()
        {
            Console.WriteLine("Kopię");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod();
            Motur m1 = new Motur();
            Koparka k1 = new Koparka();
            s1.jedz();
            s1.zaparkuj();
            m1.tankuj();
            m1.zalozKask();
            k1.tankuj();
            k1.kop();
        }
    }
}
