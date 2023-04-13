using Dzejdzicenie.Klasy;

internal class Program
{
    private static void Main(string[] args)
    {
        Osoba osoba = new Osoba("Ewogerdy", "Jajo", 'm', new DateTime(2006, 08, 02));
        Console.Write(osoba.ToString());
        osoba.ZmienDane();
        Uczen uczen = new Uczen("Anna", "Se", 'k', new DateTime(1928, 12, 12), "2D");
        Console.WriteLine(uczen);
        Console.WriteLine("zmiana1");
    }
}