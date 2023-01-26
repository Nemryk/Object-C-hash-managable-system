using System.Collections.Generic;

class Kategoria
{
    public string Nazwa { get; set; }
    public List<Danie> Dania { get; set; }

    public Kategoria(string nazwa)
    {
        Nazwa = nazwa;
        Dania = new List<Danie>();
    }
}