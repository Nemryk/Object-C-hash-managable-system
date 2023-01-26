using System.Collections.Generic;

class Danie
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    public Kategoria Kategoria { get; set; }

    public Danie(string nazwa, double cena, Kategoria kategoria)
    {
        Nazwa = nazwa;
        Cena = cena;
        Kategoria = kategoria;
    }
    public double Sum()
    {
        return Cena;
    }
}