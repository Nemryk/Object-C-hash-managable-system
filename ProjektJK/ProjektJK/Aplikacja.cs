using System.Collections.Generic;
using System;
using System.Linq;


class Aplikacja
{
    public Menu _menu;
    public List<Zamowienie> _zamowienia;
    public List<Rachunek> _rachunki;
    public List<Danie> _dania;
    public List<Kategoria> _kategorie;

    public Aplikacja()
    {
        _menu = new Menu();
        _zamowienia = new List<Zamowienie>();
        _rachunki = new List<Rachunek>();
    }

    public void DodajMenu(Menu menu)
    {
        _menu = menu;
    }

    public void DodajKategorie(Kategoria kategoria)
    {
        _kategorie.Add(kategoria);
    }

    public void DodajDanie(Danie dodaneDanie)
    {
        var kat = _menu.Kategorie.Find(k => k.Nazwa == dodaneDanie.Kategoria.Nazwa);
        if (kat == null)
        {
            kat = new Kategoria(dodaneDanie.Kategoria.Nazwa);
            _menu.Kategorie.Add(kat);
        }

        var danie = new Danie(dodaneDanie.Nazwa, dodaneDanie.Cena, kat);
        kat.Dania.Add(danie);
    }

    public void DodajZamowienie(List<Danie> dania)
    {
        var zamowienie = new Zamowienie();
        zamowienie.Dania.AddRange(dania);
        _zamowienia.Add(zamowienie);
    }

    public void DodajRachunek(Rachunek rachunek)
    {
        _rachunki.Add(rachunek);
    }
    //Funkcje zzawansowane
    //przykładowe metody wprowadzenia z konsoli
    public void WprowadzKategorieZKonsoli()
    {
        Console.WriteLine("Wprowadzanie kategorii:");
        Console.Write("Nazwa kategorii: ");
        string nazwaKategorii = Console.ReadLine();

        var kategoria = new Kategoria(nazwaKategorii);
        DodajKategorie(kategoria);
    }
    //dodanie nowego menu do listy
    public void WprowadzMenuZKonsoli()
    {
        Console.WriteLine("Wprowadzanie menu:");

        var menu = new Menu();
        DodajMenu(menu);
    }

    //przykładowa funkcja sortowania dań
    public void SortujDaniaAlfabetycznie()
    {
        _dania = _dania.OrderBy(d => d.Nazwa).ToList();
    }
    //znalezienie dania
    public Danie ZnajdzDanie(string nazwa)
    {
        return _dania.FirstOrDefault(d => d.Nazwa == nazwa);
    }
    //usuwanie dania
    public bool UsunDanie(string nazwa)
    {
        var danie = _dania.FirstOrDefault(d => d.Nazwa == nazwa);
        if (danie == null)
            return false;

        _dania.Remove(danie);
        return true;
    }
}