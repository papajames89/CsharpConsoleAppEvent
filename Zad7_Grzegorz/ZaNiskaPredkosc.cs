using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7_Grzegorz
{
	class ZaNiskaPredkosc: Exception
	{
	}
	public class OcenaPredkosci
	{
		public static void JakaPredkosc(int Predkosc1)
		{
			if (Predkosc1 <= 5)
				throw new ZaNiskaPredkosc();
		}
	}
}
