using System;
using MagazinAlimentar.Modele;
using MagazinAlimentar.NivelStocare;
using System.Linq;

namespace MagazinAlimentar
{
    class Program
    {
        static void Main()
        {
            // Creăm magazinul
            Magazin magazin = new Magazin("Supermarket");
            Console.WriteLine("Introduceti numarul de produse:");
            int nrProduse = int.Parse(Console.ReadLine());

            // Citim datele pentru fiecare produs și le adăugăm în magazin
            for (int i = 0; i < nrProduse; i++)
            {
                Console.WriteLine($"\nIntroduceti detaliile produsului {i + 1}:");

                Console.Write("Nume produs: ");
                string nume = Console.ReadLine();

                Console.Write("Pret produs: ");
                double pret = double.Parse(Console.ReadLine());

                Console.Write("Stoc produs: ");
                int stoc = int.Parse(Console.ReadLine());

                Produs produs = new Produs(nume, pret, stoc);
                magazin.AdaugaProdus(produs);
            }

            Console.WriteLine("\nProdusele adăugate în magazin:");
            magazin.AfiseazaProduse();

            Console.WriteLine("\nIntroduceti numele produsului pe care doriti sa il cautati:");
            string numeCautat = Console.ReadLine();
            Produs produsGasit = magazin.CautaProdusDupaNume(numeCautat);

            if (produsGasit != null)
            {
                Console.WriteLine("\nProdus gasit:");
                produsGasit.AfiseazaProdus();
            }
            else
            {
                Console.WriteLine("\nProdusul nu a fost gasit.");
            }

            Console.ReadKey();
        }
    }
}
