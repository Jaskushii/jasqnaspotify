using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzejdzicenie.Klasy
{
    public class Uczen : Osoba
    {
        public string Klasa { get; set; }
        public Uczen (string imie, string nazwisko, char plec, DateTime dataUrodzenia, string klasa) : base(imie, nazwisko, plec, dataUrodzenia)
        {
            this.Klasa = klasa;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Klasa: " + this.Klasa + "\n";
        }
        public override void ZmienDane()
        {
            base.ZmienDane();
            this.Klasa = "2D";
        }
    }
}
