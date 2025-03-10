using System;

namespace MagazinAlimentar.Modele
{
    public class Produs
    {
        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public double Pret { get; set; }
        public int Stoc { get; set; }

        public Produs(string nume, double pret, int stoc)
        {
            Nume = nume;
            Pret = pret;
            Stoc = stoc;
        }

        public void AfiseazaProdus()
        {
            Console.WriteLine($"Produs: {Nume}, Pret: {Pret} RON, Stoc: {Stoc} buc.");
        }
    }
}
