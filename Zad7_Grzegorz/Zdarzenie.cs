using System;
using System.Collections.Generic;
using System.Text;

namespace Zad7_Grzegorz
{
	class Zdarzenie
	{
        public delegate void Wypadek(int i);
        public event Wypadek OglosWypadek;

        public void NaOgloszenieZdarzenie(int i)
        {
            if (OglosWypadek != null)
                OglosWypadek(i);
        }
    }
}
