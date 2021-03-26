using System;

namespace Zad7_Grzegorz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Program stworzyl: Grzegorz Rzeszut";
			int wybor, predkosc;
			int p1, p2, p3, p4, p5, p6;
			string p1s, p2s, p3s, p4s, p5s, p6s;
			char znak2 = 'T';

			Hulajnoga_01 Scooter1 = new Hulajnoga_01("Hulajnoga", "Zielony", "Xiaomi", 2019, 5, 45, 1111);
			Hulajnoga_02 Scooter2 = new Hulajnoga_02("Hulajnoga", "Zielony", "Xiaomi", 2018, 4, 40, 2222);
			Hulajnoga_03 Scooter3 = new Hulajnoga_03("Hulajnoga", "Czerwony", "Segway", 2020, 6, 55, 3333);

			Rower_01 Bike1 = new Rower_01("Rower", "Czarny", "Xiaomi", 2019, 7, 65, 4444);
			Rower_02 Bike2 = new Rower_02("Rower", "Niebieski", "Segway", 2020, 6, 55, 5555);
			Rower_03 Bike3 = new Rower_03("Rower", "Czerwony", "Segway", 2020, 6, 55, 6666);


			//Glowne Menu

			int caseSwitch = 1;
			switch (caseSwitch)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Wypozyczalnia pojazdow elektrycznych");
					Console.WriteLine();
					Console.WriteLine("1. Wyswietl baze pojazdow elektrycznych");
					Console.WriteLine("2. Zglos zdarzenie/wypadek jednego z pojazdow");
					Console.WriteLine("3. Badania techniczne pojazdow - Testowanie metod wymuszonych przez interfejs");
					Console.WriteLine("4. Aktualna predkosc pojazdow - Testowanie metody abstrakcyjnej oraz wyjatku");
					Console.WriteLine("5. Zakoncz program");
					Console.WriteLine();
					znak2 = Console.ReadKey().KeyChar;
					if (znak2 == '1') { goto case 2; }
					else if (znak2 == '2') { goto case 3; }
					else if (znak2 == '3') { goto case 4; }
					else if (znak2 == '4') { goto case 5; }
					else if (znak2 == '5')
						break;
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1, 2, 3, 4 lub 5");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 1;
					}
					break;
				case 2:
					Console.Clear();



					//Wyswietl dane hulajnogi 1

					Console.WriteLine("DANE POJAZDU NR. 1:");
					Console.WriteLine("--------------------Hulajnoga----------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Scooter1.Odczytaj_Kolor, Scooter1.Odczytaj_Marke, Scooter1.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Scooter1.Odczytaj_RokProdukcji, Scooter1.Odczytaj_PojBaterii, Scooter1.Odczytaj_Zasieg);
					if (Scooter1.flaga_sprawnosc)
						Console.WriteLine("Sprawna: Tak.");
					else
						Console.WriteLine("Sprawna: Nie.");
					Console.WriteLine();
					Console.WriteLine();



					//Wyswietl dane hulajnogi 2

					Console.WriteLine("DANE POJAZDU NR. 2:");
					Console.WriteLine("--------------------Hulajnoga----------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Scooter2.Odczytaj_Kolor, Scooter2.Odczytaj_Marke, Scooter2.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Scooter2.Odczytaj_RokProdukcji, Scooter2.Odczytaj_PojBaterii, Scooter2.Odczytaj_Zasieg);
					if (Scooter2.flaga_sprawnosc)
						Console.WriteLine("Sprawna: Tak.");
					else
						Console.WriteLine("Sprawna: Nie.");
					Console.WriteLine();
					Console.WriteLine();



					//Wyswietl dane hulajnogi 3

					Console.WriteLine("DANE POJAZDU NR. 3:");
					Console.WriteLine("--------------------Hulajnoga----------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Scooter3.Odczytaj_Kolor, Scooter3.Odczytaj_Marke, Scooter3.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Scooter3.Odczytaj_RokProdukcji, Scooter3.Odczytaj_PojBaterii, Scooter3.Odczytaj_Zasieg);
					if (Scooter3.flaga_sprawnosc)
						Console.WriteLine("Sprawna: Tak.");
					else
						Console.WriteLine("Sprawna: Nie.");
					Console.WriteLine();
					Console.WriteLine();



					//Wyswietl dane rower 1

					Console.WriteLine("DANE POJAZDU NR. 4:");
					Console.WriteLine("----------------------Rower------------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Bike1.Odczytaj_Kolor, Bike1.Odczytaj_Marke, Bike1.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Bike1.Odczytaj_RokProdukcji, Bike1.Odczytaj_PojBaterii, Bike1.Odczytaj_Zasieg);
					if (Bike1.flaga_sprawnosc)
						Console.WriteLine("Sprawny: Tak.");
					else
						Console.WriteLine("Sprawny: Nie.");
					Console.WriteLine();
					Console.WriteLine();



					//Wyswietl dane rower 2

					Console.WriteLine("DANE POJAZDU NR. 5:");
					Console.WriteLine("----------------------Rower------------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Bike2.Odczytaj_Kolor, Bike2.Odczytaj_Marke, Bike2.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Bike2.Odczytaj_RokProdukcji, Bike2.Odczytaj_PojBaterii, Bike2.Odczytaj_Zasieg);
					if (Bike2.flaga_sprawnosc)
						Console.WriteLine("Sprawny: Tak.");
					else
						Console.WriteLine("Sprawny: Nie.");
					Console.WriteLine();
					Console.WriteLine();




					//Wyswietl dane rower 3

					Console.WriteLine("DANE POJAZDU NR. 6:");
					Console.WriteLine("----------------------Rower------------------------");
					Console.WriteLine();
					Console.WriteLine("Kolor: {0}, Marka: {1}, Numer Seryjny: {2}.", Bike3.Odczytaj_Kolor, Bike3.Odczytaj_Marke, Bike3.Odczytaj_NumerSeryjny);
					Console.WriteLine("Rok produkcji: {0}r., Akumulator: {1}Ah, Zasieg: {2}km.", Bike3.Odczytaj_RokProdukcji, Bike3.Odczytaj_PojBaterii, Bike3.Odczytaj_Zasieg);
					if (Bike3.flaga_sprawnosc)
						Console.WriteLine("Sprawny: Tak.");
					else
						Console.WriteLine("Sprawny: Nie.");
					Console.WriteLine();
					Console.WriteLine();


					Console.WriteLine();
					Console.WriteLine("1. Wroc do glownego menu");
					Console.WriteLine("2. Zakoncz program");
					Console.WriteLine();
					znak2 = Console.ReadKey().KeyChar;
					if (znak2 == '1') { goto case 1; }
					else if (znak2 == '2')
						break;
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 2;
					}
					break;

				case 3:


					Console.Clear();


					//Obsluga zdarzenia

					Console.WriteLine("Który pojazd uległ wypadkowi?");
					Console.WriteLine("1 - {0} {1} nr. seryjny: {2}", Scooter1.Odczytaj_TypPojazdu, Scooter1.Odczytaj_Marke, Scooter1.Odczytaj_NumerSeryjny);
					Console.WriteLine("2 - {0} {1} nr. seryjny: {2}", Scooter2.Odczytaj_TypPojazdu, Scooter2.Odczytaj_Marke, Scooter2.Odczytaj_NumerSeryjny);
					Console.WriteLine("3 - {0} {1} nr. seryjny: {2}", Scooter3.Odczytaj_TypPojazdu, Scooter3.Odczytaj_Marke, Scooter3.Odczytaj_NumerSeryjny);
					Console.WriteLine("4 - {0} {1} nr. seryjny: {2}", Bike1.Odczytaj_TypPojazdu, Bike1.Odczytaj_Marke, Bike1.Odczytaj_NumerSeryjny);
					Console.WriteLine("5 - {0} {1} nr. seryjny: {2}", Bike2.Odczytaj_TypPojazdu, Bike2.Odczytaj_Marke, Bike2.Odczytaj_NumerSeryjny);
					Console.WriteLine("6 - {0} {1} nr. seryjny: {2}", Bike3.Odczytaj_TypPojazdu, Bike3.Odczytaj_Marke, Bike3.Odczytaj_NumerSeryjny);
					Console.WriteLine();
					wybor = Console.ReadKey().KeyChar;
					Console.WriteLine();
					Console.WriteLine();
					Console.Write("Podaj predkosc w km/h z jaka pojazd ulegl wypadkowi: ");
					predkosc = int.Parse(Console.ReadLine().ToString());
					Console.WriteLine();

					Zdarzenie Twypadek = new Zdarzenie();
					if (wybor == '1')
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Akcja);
						Scooter1.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Reakcja);
					}
					else if (wybor == '2')
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Akcja);
						Scooter2.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Reakcja);
					}
					else if (wybor == '3')
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Akcja);
						Scooter3.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Reakcja);
					}
					else if (wybor == '4')
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Akcja);
						Bike1.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Reakcja);
					}
					else if (wybor == '5')
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Akcja);
						Bike2.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Reakcja);
					}
					else
					{
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike3.Akcja);
						Bike3.flaga_sprawnosc = false;
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Bike2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter1.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter2.Reakcja);
						Twypadek.OglosWypadek += new Zdarzenie.Wypadek(Scooter3.Reakcja);
					}

					Twypadek.NaOgloszenieZdarzenie(predkosc);

					Console.WriteLine();
					Console.WriteLine("1. Wroc do glownego menu");
					Console.WriteLine("2. Zakoncz program");
					Console.WriteLine();
					znak2 = Console.ReadKey().KeyChar;
					if (znak2 == '1') { goto case 1; }
					else if (znak2 == '2')
						break;
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 2;
					}
					break;


				case 4:

					//Testowanie metod wymuszonych przez interfejs

					Console.Clear();
					Scooter1.InformacjaOSerwisie("Hulajnoga u numerze seryjnym " + Scooter1.Odczytaj_NumerSeryjny);
					Scooter1.SerwisPojazdu(true);
					Console.WriteLine();
					Scooter2.InformacjaOSerwisie("Hulajnoga u numerze seryjnym " + Scooter2.Odczytaj_NumerSeryjny);
					Scooter2.SerwisPojazdu(true);
					Console.WriteLine();
					Scooter3.InformacjaOSerwisie("Hulajnoga u numerze seryjnym " + Scooter3.Odczytaj_NumerSeryjny);
					Scooter3.SerwisPojazdu(false);
					Console.WriteLine();
					Bike1.InformacjaOSerwisie("Rower u numerze seryjnym " + Bike1.Odczytaj_NumerSeryjny);
					Bike1.SerwisPojazdu(true);
					Console.WriteLine();
					Bike2.InformacjaOSerwisie("Rower u numerze seryjnym " + Bike2.Odczytaj_NumerSeryjny);
					Bike2.SerwisPojazdu(false);
					Console.WriteLine();
					Bike3.InformacjaOSerwisie("Rower u numerze seryjnym " + Bike3.Odczytaj_NumerSeryjny);
					Bike3.SerwisPojazdu(false);
					Console.WriteLine();

					Console.WriteLine();
					Console.WriteLine("1. Wroc do glownego menu");
					Console.WriteLine("2. Zakoncz program");
					Console.WriteLine();
					znak2 = Console.ReadKey().KeyChar;
					if (znak2 == '1') { goto case 1; }
					else if (znak2 == '2')
						break;
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 2;
					}
					break;



				case 5:

					Console.Clear();

					//Testowanie wyjatku

					//H1
					try
					{
						p1 = 3;
						p1s = Scooter1.AktualnaPredkosc(p1);
						OcenaPredkosci.JakaPredkosc(p1);
						Console.WriteLine(p1s);
						
					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Scooter1.Odczytaj_NumerSeryjny);
						//Console.WriteLine();
					}

					//H2
					try
					{
						p2 = 15;
						p2s = Scooter2.AktualnaPredkosc(p2);
						OcenaPredkosci.JakaPredkosc(p2);
						Console.WriteLine(p2s);

					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Scooter2.Odczytaj_NumerSeryjny);
						Console.WriteLine();
					}


					//H3
					try
					{
						p3 = 35;
						p3s = Scooter3.AktualnaPredkosc(p3);
						OcenaPredkosci.JakaPredkosc(p3);
						Console.WriteLine(p3s);

					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Scooter3.Odczytaj_NumerSeryjny);
						Console.WriteLine();
					}


					//R1
					try
					{
						p4 = 45;
						p4s = Bike1.AktualnaPredkosc(p4);
						OcenaPredkosci.JakaPredkosc(p4);
						Console.WriteLine(p4s);

					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Bike1.Odczytaj_NumerSeryjny);
						Console.WriteLine();
					}


					//R2
					try
					{
						p5 = 35;
						p5s = Bike2.AktualnaPredkosc(p5);
						OcenaPredkosci.JakaPredkosc(p5);
						Console.WriteLine(p5s);

					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Bike2.Odczytaj_NumerSeryjny);
						Console.WriteLine();
					}



					//R3
					try
					{
						p6 = 5;
						p6s = Bike3.AktualnaPredkosc(p6);
						OcenaPredkosci.JakaPredkosc(p6);
						Console.WriteLine(p6s);

					}
					catch (ZaNiskaPredkosc)
					{
						Console.WriteLine("Pojazd u numerze seryjnym {0} porusza sie zbyt wolno. Wywolanie wyjatku", Bike3.Odczytaj_NumerSeryjny);
						Console.WriteLine();
					}


					Console.WriteLine();
					Console.WriteLine("1. Wroc do glownego menu");
					Console.WriteLine("2. Zakoncz program");
					Console.WriteLine();
					znak2 = Console.ReadKey().KeyChar;
					if (znak2 == '1') { goto case 1; }
					else if (znak2 == '2')
						break;
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 2;
					}
					break;







			}

			
		}
	}
}
