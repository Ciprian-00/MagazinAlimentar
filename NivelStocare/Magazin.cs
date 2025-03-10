using System.Linq;
using System;
using MagazinAlimentar.Modele;
using System.Collections.Generic;

namespace MagazinAlimentar.NivelStocare
{
    public class Magazin
    {
        public string Nume { get; set; }
        public List<Produs> Produse { get; set; }

        public Magazin(string nume)
        {
            Nume = nume;
            Produse = new List<Produs>();
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        public void AfiseazaProduse()
        {
            Console.WriteLine($"Produse din magazinul {Nume}:");
            foreach (var produs in Produse)
            {
                produs.AfiseazaProdus();
            }
        }

        public Produs CautaProdusDupaNume(string nume)
        {
            return Produse.FirstOrDefault(p => p.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase));
        }
    }
}
