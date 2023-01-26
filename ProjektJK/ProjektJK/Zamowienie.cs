using System.Collections.Generic;
using System.Linq;

class Zamowienie
{
    public List<Danie> Dania { get; set; }
    public double LacznaCena { get { return Dania.Sum(d => d.Cena); } }

    public Zamowienie()
    {
        Dania = new List<Danie>();
    }
}