using System;

namespace projekt1
{
    class Rower
    {
        private Producent producent;
        private string kolor;
        private Material material;
        
        public Rower(Producent aproducent){
            this.producent = aproducent;
        }

        public void jedz()
        {
            Console.WriteLine("Jadę...");
        }
        public void setColor(acolor)
        {
            this.kolor = acolor;
        }
        public string getColor()
        {
            return this.color;
        }
    }

    class Producent
    {
        private string nazwa;
        private string nip;
        
        public string getNazwa()
        {
            return this.nazwa;
        }
        public string getNip(){
            return this.nip;
        }
        public void setNazwa(anazwa){
            this.nazwa = anazwa;
        }
    }

    class Material
    {
        private string typ;
        private int id;
        private double cena;

        public void setTyp(atyp)
        {
            this.typ = atyp;
        }
        public string getTyp()
        {
            return this.typ;
        }
        public double getCena()
        {
            return this.cena;
        }
        public void setId(aid)
        {
            this.id = aid;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Producent p = new Producent();
            Material m = new Material();
            Rower r = new Rower(p);
        }
    }
}
