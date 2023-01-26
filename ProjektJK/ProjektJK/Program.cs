using System.Collections.Generic;
using System;


class Program
{
    static void Main(string[] args)
    {
        var aplikacja = new Aplikacja();

        // Dodanie dań oraz subdań do menu
        aplikacja.DodajDanie(new Danie("Zupa pomidorowa", 12.50, new Kategoria("Zupy")));
        aplikacja.DodajDanie(new Danie("Spaghetti Bolognese", 25.00, new Kategoria("Dania główne")));
        aplikacja.DodajDanie(new Danie("Lody z owocami", 15.00, new Kategoria("Desery")));
        aplikacja.DodajDanie(new DanieMięsne("Kotlet schabowy", 25.00, new Kategoria("Dania główne")));
        aplikacja.DodajDanie(new DanieVege("Sałatka warzywna", 18.00, new Kategoria("Dania główne")));
        aplikacja.DodajDanie(new DanieRybne("Łosoś z pieca", 30.00, new Kategoria("Dania główne")));

        // przykładowe zamówienie
        var zamowienie = new List<Danie>()
        {
            aplikacja._menu.Kategorie.Find(k=>k.Nazwa=="Zupy").Dania.Find(d=>d.Nazwa=="Zupa pomidorowa"),
            aplikacja._menu.Kategorie.Find(k=>k.Nazwa=="Dania główne").Dania.Find(d=>d.Nazwa=="Spaghetti Bolognese"),
            aplikacja._menu.Kategorie.Find(k=>k.Nazwa=="Desery").Dania.Find(d=>d.Nazwa=="Lody z owocami"),
        };
        aplikacja._dania = zamowienie;
        aplikacja.DodajZamowienie(zamowienie);
        aplikacja.DodajRachunek(new Rachunek(aplikacja._zamowienia[0], false));
        Console.WriteLine("Rachunek");
        for (int i = 0; i < aplikacja._rachunki.Count; i++)
        {
            for (int j = 0; j < aplikacja._rachunki[i].Zamowienie.Dania.Count; j++)
            {
                Console.WriteLine(aplikacja._rachunki[i].Zamowienie.Dania[j].Nazwa);
            }
        }
        //dodatkowe zamówienie
        aplikacja.DodajZamowienie(zamowienie);
        //dodatkowa faktura oraz dodatkowy paragon
        var faktura = new Faktura(aplikacja._zamowienia[1]);
        var paragon = new Paragon(aplikacja._zamowienia[1]);
        aplikacja.DodajRachunek(faktura);
        aplikacja.DodajRachunek(paragon);
        //przykladowe zastosowanie funkcji za pomocą konsoli
        aplikacja.SortujDaniaAlfabetycznie();
        aplikacja.WprowadzKategorieZKonsoli();
        aplikacja.WprowadzMenuZKonsoli();
        aplikacja.ZnajdzDanie("Lody z owocami");
        aplikacja.UsunDanie("Lody z owocami");
    }
}