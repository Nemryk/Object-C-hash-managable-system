using System.Collections.Generic;

class Faktura : Rachunek
{
    public Faktura(Zamowienie zamowienie) : base(zamowienie, true) { }
}

class Paragon : Rachunek
{
    public Paragon(Zamowienie zamowienie) : base(zamowienie, false) { }
}