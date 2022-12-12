using System;

namespace projekt1
{
    class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;
        
        public string getNazwa()
        {
            return this.nazwa;
        }
        public double getCena(){
            return this.cena;
        }
        public string getOpis(){
            return this.opis;
        }
        public Produkt(anazwa,acena,aopis){
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }
    }

    class Profil
    {
        private string imie;
        private string drugieImie;
        private string nazwisko;

        public string getImie()
        {
            return this.imie;
        }
        public string getNazwisko()
        {
            return this.nazwisko;
        }
    }

    class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;

        public Uzytkownik(Profil aprofil)
        {
            this.profil = aprofil;
        }
        public void loguj()
        {
            Console.WriteLine("Logowanie...");
        }
    }

    class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        
        public Koszyk(Produkt aprodukt){
            this.produkt = aprodukt;
        }

        public int getId()
        {
            return this.id;
        }
        public void operation()
        {
            Console.WriteLine("Operacja...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Produkt prod = new Produkt();
            Profil prof = new Profil();
            Uzytkownik u = new Uzytkownik(prof);
            Koszyk k = new Koszyk(prod);
        }
    }
}
