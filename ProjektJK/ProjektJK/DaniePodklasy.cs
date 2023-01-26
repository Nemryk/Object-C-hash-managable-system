using System.Collections.Generic;

class DanieRybne : Danie
{
    public DanieRybne(string nazwa, double cena, Kategoria kategoria) : base(nazwa, cena, kategoria) { }
}

class DanieVege : Danie
{
    public DanieVege(string nazwa, double cena, Kategoria kategoria) : base(nazwa, cena, kategoria) { }
}

class DanieMięsne : Danie
{
    public DanieMięsne(string nazwa, double cena, Kategoria kategoria) : base(nazwa, cena, kategoria) { }
}