# MagazinAlimentar

Aplicație desktop în C# (Windows Forms) pentru gestionarea unui magazin alimentar, dezvoltată ca proiect individual la materia PIU (Proiectarea Interfețelor Utilizator).

## Descriere

Aplicația simulează un sistem de gestiune pentru un magazin alimentar, cu două roluri distincte de utilizator: **Client** și **Angajat**. Combină noțiuni de programare orientată pe obiecte cu interacțiunea vizuală specifică aplicațiilor Windows Forms.

## Funcționalități

### Modul Client
- Creare cont (înregistrare cu nume de utilizator și parolă)
- Autentificare
- Vizualizare listă de produse disponibile
- Selectare și cumpărare produse

### Modul Angajat
- Adăugare produs nou
- Modificare produs existent
- Ștergere produs
- Afișare listă completă de produse
- Căutare produs (case-insensitive)

## Arhitectură

Aplicația este structurată pe clase cu responsabilități clar separate:

- **`Produs`** — clasa principală, conține atributele fiecărui produs: `IdProdus`, `Nume`, `Pret`, `Stoc`, `Grupa`, `Tip`, `Promotie`
- **`GrupaProdus`** — enum pentru clasificarea produselor: Lactate, Panificație, Carne, Legume/Fructe, Băuturi
- **`AdministrareMagazin_FisierText`** — clasa responsabilă cu persistența datelor (citire/scriere din fișier), expune metode precum `AddProdus`, `GetProduse`, `UpdateProdus`, `StergeProdusDupaId`
- **Formulare individuale** pentru fiecare funcționalitate: `FormAdaugaProdus`, `FormModificaProdus`, `FormCautaProdus`, `FormProduse`, `FormAutentificareClient`, `FormCumparaProduse`

## Detalii de implementare

- Validare completă a datelor la adăugarea/modificarea unui produs
- Utilizare de `TryParse` pentru prevenirea erorilor de conversie
- Ștergere produs direct din formularul principal (`FormProduse`), fără formulare separate
- Persistență a datelor printr-un fișier text, cu logică unitară de acces

## Tehnologii

- C#
- Windows Forms (.NET Framework)

## Posibile dezvoltări ulterioare

- Salvarea comenzilor plasate de clienți într-un fișier sau bază de date
- Autentificare angajat cu permisiuni avansate
- Sistem de stocuri automate, cu notificări la stoc scăzut
- Trecerea de la stocare pe fișier text la o bază de date SQL

## Documentatie 

- Documentația completă a proiectului este [aici](https://github.com/Ciprian-00/MagazinAlimentar/blob/main/Documentatie_Proiect_Magazin_Alimentar.pdf).
## Rulare

1. Deschide `MagazinAlimentar.sln` în Visual Studio
2. Setează `MagazinAlimentar` ca proiect de pornire
3. Rulează aplicația (F5)
4. Din meniul principal, alege Client (înregistrare/autentificare/cumpărare) sau Angajat (gestionare produse)
