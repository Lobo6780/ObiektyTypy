using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Przychodnia
    {
        private string adres;
        private string[] lekarze;

        //metoda "normalna"
        public void przywitajPacjenta()
        {
            Console.WriteLine("Witam cię");
        }

        //metoda statyczna
        public static void pokazRegulamin()
        {
            Console.WriteLine("Proszę zapoznać się z regulaminem...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Przychodnia p = new Przychodnia();
            p.przywitajPacjenta();
            //p.pokazRegulamin(); // błąd!

            Przychodnia.pokazRegulamin();
        }
    }
}
