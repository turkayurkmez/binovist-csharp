// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

Asci asci = new Asci();
Kofte kofte = new Kofte() { KasarliMi = false, Ad = "Köfte", PismeModu = 3, PismeSuresi = 40 };
PirasaYemegi pirasaYemegi = new PirasaYemegi() { Ad = "Zeytinyağlı pırasa", PismeSuresi = 30, SogukMu = true, ZeytinyagliMi = true };
TulumbaTatlisi tulumbaTatlisi = new TulumbaTatlisi { SerbetliMi = true, Ad = "Osmanlı tulumbası" };

asci.Pisir(pirasaYemegi);
Console.WriteLine(pirasaYemegi);
asci.Pisir(kofte);
asci.Pisir(tulumbaTatlisi);

