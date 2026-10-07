
using CukraszdaNyilvantartas;

List<sutemeny> lista = new List<sutemeny>();

for (int i = 0; i < 4; i++)
{
    sutemeny peldany = new sutemeny();

    Console.WriteLine("Név: ");
    string nev = Console.ReadLine();

    Console.Write("Egységár: ");
    int egysegar = int.Parse(Console.ReadLine());

    Console.Write("Raktáron lévő darabszám: ");
    int raktaronDb = int.Parse(Console.ReadLine());

    peldany.nev = nev;
    peldany.egysegar = egysegar;
    peldany.raktaronDb = raktaronDb;

    lista.Add(peldany);
}

int teljesKeszletErtek = 0;

for (int i = 0; i < lista.LongCount(); i++)
{
    teljesKeszletErtek += lista[i].egysegar * lista[i].raktaronDb;
    
}

double atlag = teljesKeszletErtek / lista.LongCount();

string statusz;

if (teljesKeszletErtek >= 40000)
{
    statusz = "Bőséges kínálat!";
}
else if (teljesKeszletErtek >= 20000) statusz = "Átlagis feltöltöttség.";
else statusz = "Alacsony készlet, utántöltés szükséges!";

