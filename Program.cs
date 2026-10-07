
using CukraszdaNyilvantartas;

List<sutemeny> lista = new List<sutemeny>();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{i + 1}. sütemény adatai:");
    sutemeny peldany = new sutemeny();

    Console.Write("\tNév: ");
    string nev = Console.ReadLine();

    Console.Write("\tEgységár (Ft): ");
    int egysegar = int.Parse(Console.ReadLine());

    Console.Write("\tRaktáron lévő darabszám (db): ");
    int raktaronDb = int.Parse(Console.ReadLine());

    peldany.nev = nev;
    peldany.egysegar = egysegar;
    peldany.raktaronDb = raktaronDb;

    lista.Add(peldany);
}

Console.WriteLine("\nPultban lévő ütemények:");
for (int i = 0; i < lista.Count;i++)
{

    Console.WriteLine($"\t- {lista[i].nev}: {lista[i].egysegar} Ft/db ({lista[i].raktaronDb} db) -> Öszérték: {lista[i].egysegar * lista[i].raktaronDb} Ft");
}

int teljesKeszletErtek = 0;
int osszdarab = 0;

for (int i = 0; i < lista.LongCount(); i++)
{
    teljesKeszletErtek += lista[i].egysegar * lista[i].raktaronDb;
    osszdarab += lista[i].raktaronDb;
    
}

double atlag = (double)teljesKeszletErtek / (double)osszdarab;

string statusz;

if (teljesKeszletErtek >= 40000)
{
    statusz = "Bőséges kínálat!";
}
else if (teljesKeszletErtek >= 20000) statusz = "Átlagis feltöltöttség.";
else statusz = "Alacsony készlet, utántöltés szükséges!";

Console.WriteLine($"\nPult teljes készletértéke: {teljesKeszletErtek} Ft");
Console.WriteLine($"Sütemények átlagos egységára: {Math.Round(atlag, 0)} Ft");
Console.WriteLine($"Készlet státusza: {statusz}");