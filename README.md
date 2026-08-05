# MagazinAlimentar
Aplicație de consolă în C# pentru gestionarea produselor unui magazin alimentar, dezvoltată ca proiect individual la materia PIU (Proiectarea Interfețelor Utilizator).

Descriere
Aplicația permite introducerea unui număr de produse (nume, preț, stoc), afișarea listei complete de produse și căutarea unui produs după nume. Proiectul este structurat pe mai multe straturi (layere), fiecare cu propriul proiect C# în cadrul soluției:

Modele — definește entitatea Produs (nume, preț, stoc) și logica de afișare a unui produs
NivelStocare — definește entitatea Magazin, care gestionează colecția de produse: adăugare, afișare, căutare
MagazinAlimentar (proiect principal) — punctul de intrare al aplicației, gestionează interacțiunea cu utilizatorul prin consolă

Funcționalități
- Adăugarea unui număr variabil de produse, introduse interactiv de utilizator
- Afișarea tuturor produselor din magazin
- Căutarea unui produs după nume, cu comparare case-insensitive (folosind LINQ)

Tehnologii
- C#
- .NET Framework
- LINQ

Arhitectură
Proiectul este organizat pe principiul separării responsabilităților (separation of concerns), cu straturi distincte pentru modelul de date și logica de business, fiecare fiind un proiect C# separat inclus în aceeași soluție (.sln).

Rulare
1. Deschide MagazinAlimentar.sln în Visual Studio
2. Setează MagazinAlimentar ca proiect de pornire
3. Rulează aplicația (F5)
4. Urmează instrucțiunile din consolă pentru a introduce și căuta produse
