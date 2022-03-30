using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;
        private int letztesErgebnis;
        private bool gesichert;
        private Random rnd;

        Wuerfel()
        {
        }

        Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }

        public int AnzahlSeiten
        {
            get;
        }

        public int LetztesErgebnis
        {
            get;
        }


    }
}
