using System;
using System.Collections.Generic;
using System.Text;

namespace Zad7_Grzegorz
{
	abstract class Pojazdy
	{
        protected string Kolor, Marka, TypPojazdu;
        protected int RokProdukcji;
        protected int PojBaterii;
        protected int Zasieg;
        protected int NumerSeryjny;

        public Pojazdy()
        {
            TypPojazdu = "Default";
            Kolor = "Default";
            Marka = "Hulajnoga marka 1";
            RokProdukcji = 2020;
            PojBaterii = 2700;
            Zasieg = 30;
            NumerSeryjny = 00000;
        }

        public Pojazdy(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny)
        {
            this.TypPojazdu = TypPojazdu;
            this.Kolor = Kolor;
            this.Marka = Marka;
            this.RokProdukcji = RokProdukcji;
            this.PojBaterii = PojBaterii;
            this.Zasieg = Zasieg;
            this.NumerSeryjny = NumerSeryjny;
        }


        public string Odczytaj_TypPojazdu
        {
            get { return TypPojazdu; }
        }
        public string Odczytaj_Kolor
        {
            get { return Kolor; }
        }

        public string Odczytaj_Marke
        {
            get { return Marka; }
        }

        public int Odczytaj_RokProdukcji
        {
            get { return RokProdukcji; }
        }

        public int Odczytaj_PojBaterii
        {
            get { return PojBaterii; }
        }
        public int Odczytaj_Zasieg
        {
            get { return Zasieg; }
        }

        public int Odczytaj_NumerSeryjny
        {
            get { return NumerSeryjny; }
        }

        public abstract string AktualnaPredkosc(int Predkosc);
    }

    interface IPojazdy 
    {
        void SerwisPojazdu(bool Serwis);
        void InformacjaOSerwisie(string info);
    }
}
