using System;
using System.Collections.Generic;
using System.Text;

namespace Zad7_Grzegorz
{
	class Hulajnoga_01:Pojazdy, IPojazdy
	{
		
        public bool flaga_sprawnosc;

        public Hulajnoga_01(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {

            flaga_sprawnosc = true;
        }


        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie hulajnogi {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 10)
            {
                Console.WriteLine("Wypadek niegroźny.");
                flaga_sprawnosc = false;
                Console.WriteLine();
            }
            else if ((i >= 10) && (i <= 20))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                flaga_sprawnosc = false;
                Console.WriteLine();
            }
            else if (i > 20)
            {
                Console.WriteLine("Poważny wypadek.");
                flaga_sprawnosc = false;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Błędna liczba.");
                flaga_sprawnosc = false;
                Console.WriteLine();
            }
        }

        public void Reakcja(int i)
        {
            if (flaga_sprawnosc)
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawna.");
            else
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

        public override string AktualnaPredkosc(int Predkosc)
        {
            string Text;
            if (Predkosc > 30)
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij!";
                Console.WriteLine();
            }
            else
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc";
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
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Hulajnoga_01");
            Console.WriteLine(info);
        }

    }

    class Hulajnoga_02 : Pojazdy, IPojazdy
    {

        public bool flaga_sprawnosc;

        public Hulajnoga_02(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {
            flaga_sprawnosc = false;
        }


        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie hulajnogi {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 10)
            {
                Console.WriteLine("Wypadek niegroźny.");
                Console.WriteLine();
            }
            else if ((i >= 10) && (i <= 20))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                Console.WriteLine();
            }
            else if (i > 20)
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
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawna.");
            else
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

        public override string AktualnaPredkosc(int Predkosc)
        {
            string Text;
            if (Predkosc > 30)
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij!";
                Console.WriteLine();
            }
            else
            {
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc";
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
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Hulajnoga_02");
            Console.WriteLine(info);
        }
    }

    class Hulajnoga_03 : Pojazdy, IPojazdy
    {

        public bool flaga_sprawnosc;

        public Hulajnoga_03(string TypPojazdu, string Kolor, string Marka, int RokProdukcji, int PojBaterii, int Zasieg, int NumerSeryjny) : base(TypPojazdu, Kolor, Marka, RokProdukcji, PojBaterii, Zasieg, NumerSeryjny)
        {

            flaga_sprawnosc = true;
        }

        public bool Sprawnosc()
        {
            return flaga_sprawnosc;
        }

        public void Akcja(int i)
        {
            Console.WriteLine("Zdarzenie hulajnogi {0} nr. seryjny {1}: ", Marka, NumerSeryjny);
            if (i < 10)
            {
                Console.WriteLine("Wypadek niegroźny.");
                Console.WriteLine();
            }
            else if ((i >= 10) && (i <= 20))
            {
                Console.WriteLine("Lekkie uszkodzenia.");
                Console.WriteLine();
            }
            else if (i > 20)
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
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": sprawna.");
            else
                Console.WriteLine("Hulajnoga " + Marka + " nr. seryjny " + NumerSeryjny + ": w naprawie.");
        }

        public override string AktualnaPredkosc(int Predkosc)
        {
            string Text;
            if (Predkosc > 30)
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. UWAGA! Zwolnij!";
                Console.WriteLine();
            }
            else
            { 
                Text = "Aktualna predkosc pojazdu o numerze seryjnym " + NumerSeryjny + " wynosi " + Predkosc.ToString() + "km/h. Zachowaj bezpieczna predkosc";
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
            Console.WriteLine("Oto wywolanie metody wymuszonej przez interfejs w Hulajnoga_03");
            Console.WriteLine(info);
        }
    }
}
