using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzejdzicenie.Klasy
{
    public class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }
        protected char Plec { get; set; }
        protected DateTime DataUrodzenia { get; set; }
        public Osoba(string imie, string nazwisko, char plec, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            DataUrodzenia = dataUrodzenia;
        }
        public virtual void ZmienDane()
        {
            this.Imie = "Adam";
            this.Nazwisko = "Kowalski";
        }
       
        public override string ToString()
        {
            return Imie + " " + Nazwisko + "\n" + "Data urodzenia: " + DataUrodzenia.ToString("D");
        }
    }
}
