using System;
using System.Collections.Generic;
using System.Text;

namespace Zad7_Grzegorz
{
    class Rower_01 : Pojazdy, IPojazdy
    {

        public bool flaga_sprawnosc;

        public Rower_01(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {
            flaga_sprawnosc = true;
        }

        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie roweru {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 15)
            {
                Console.WriteLine("Wypadek niegroźny.");
                Console.WriteLine();
            }
            else if ((i >= 15) && (i <= 25))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                Console.WriteLine();
            }
            else if (i > 25)
            {
                {
                    Console.WriteLine("Poważny wypadek.");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Błędna liczba.");
            Console.WriteLine();
        }

        public void Reakcja(int i)
        {
            if (flaga_sprawnosc)
                Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawny.");
            else
                Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

		public override string AktualnaPredkosc(int Predkosc)
		{
            string Text;
            if (Predkosc > 40)
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij! Dziekujemy.";
                Console.WriteLine();
            }
            else
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc. Dziekujemy.";
                Console.WriteLine();
            }
                return Text;
        }
        public void SerwisPojazdu(bool Serwis)
        {
            if (Serwis)
                Console.WriteLine("Ukonczyly sie badania techniczne pojazdu.");
            else
                Console.WriteLine("Batania techniczne pojazdu sa aktualne.");
        }
        public void InformacjaOSerwisie(string info)
        {
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Rower_01");
            Console.WriteLine(info);
        }

    }

    class Rower_02 : Pojazdy, IPojazdy
    {

        public bool flaga_sprawnosc;

        public Rower_02(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {
            flaga_sprawnosc = false;
        }

        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie roweru {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 15)
            {
                Console.WriteLine("Wypadek niegroźny.");
                Console.WriteLine();
            }
            else if ((i >= 15) && (i <= 25))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                Console.WriteLine();
            }
            else if (i > 25)
            {
                Console.WriteLine("Poważny wypadek.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Błędna liczba.");
                Console.WriteLine();
            }
        }

        public void Reakcja(int i)
        {
            if (flaga_sprawnosc)
                Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawny.");
            else
                Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

        public override string AktualnaPredkosc(int Predkosc)
        {
            string Text;
            if (Predkosc > 40)
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij! Dziekujemy.";
                Console.WriteLine();
            }
            else
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc. Dziekujemy.";
                Console.WriteLine();
            }
            return Text;
        }
        public void SerwisPojazdu(bool Serwis)
        {
            if (Serwis)
                Console.WriteLine("Ukonczyly sie badania techniczne pojazdu.");
            else
                Console.WriteLine("Batania techniczne pojazdu sa aktualne.");
        }
        public void InformacjaOSerwisie(string info)
        {
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Rower_02");
            Console.WriteLine(info);
        }
    }

    class Rower_03 : Pojazdy, IPojazdy
    {

        public bool flaga_sprawnosc;

        public Rower_03(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {
            flaga_sprawnosc = true;
        }

        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie roweru {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 15)
            {
                Console.WriteLine("Wypadek niegroźny.");
                Console.WriteLine();
            }
            else if ((i >= 15) && (i <= 25))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                Console.WriteLine();
            }
            else if (i > 25)
            {
                Console.WriteLine("Poważny wypadek.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Błędna liczba.");
                Console.WriteLine();
            }
        }

        public void Reakcja(int i)
        {
            if(flaga_sprawnosc)
            Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawny.");
            else
                Console.WriteLine("Rower " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

        public override string AktualnaPredkosc(int Predkosc)
        {
            string Text;
            if (Predkosc > 40)
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij! Dziekujemy.";
                Console.WriteLine();
            }
            else
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc. Dziekujemy.";
                Console.WriteLine();
            }
            return Text;
        }
        public void SerwisPojazdu(bool Serwis)
        {
            if (Serwis)
                Console.WriteLine("Ukonczyly sie badania techniczne pojazdu.");
            else
                Console.WriteLine("Batania techniczne pojazdu sa aktualne.");
        }
        public void InformacjaOSerwisie(string info)
        {
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Rower_03");
            Console.WriteLine(info);
        }
    }
}
