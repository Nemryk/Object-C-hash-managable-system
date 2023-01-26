using System.Collections.Generic;

class Rachunek
{
    public Zamowienie Zamowienie { get; set; }
    public double LacznaCena { get { return Zamowienie.LacznaCena; } }
    public bool CzyZgóry { get; set; }

    public Rachunek(Zamowienie zamowienie, bool czyZgóry)
    {
        Zamowienie = zamowienie;
        CzyZgóry = czyZgóry;
    }
}