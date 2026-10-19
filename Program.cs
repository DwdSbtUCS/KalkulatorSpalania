using System;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pl-PL");

string[] marki = new string[3];
string[] modele = new string[3];
double[] dystanse = new double[3];
double[] paliwo = new double[3];
double[] spalanie = new double[3];

Console.WriteLine("Muli Car Care");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\nSamochód {i + 1}");

    Console.Write("Podaj markę: ");
    marki[i] = Console.ReadLine() ?? "";

    Console.Write("Podaj model: ");
    modele[i] = Console.ReadLine() ?? "";

    do
    {
        Console.Write("Podaj przejechany dystans [km] (większy od 0): ");
        dystanse[i] = Convert.ToDouble(Console.ReadLine());
    }
    while (dystanse[i] <= 0);

    do
    {
        Console.Write("Podaj zużyte paliwo [l] (nieujemne): ");
        paliwo[i] = Convert.ToDouble(Console.ReadLine());
    }
    while (paliwo[i] < 0);

    spalanie[i] = paliwo[i] / dystanse[i] * 100;
}

Console.WriteLine("\nWyniki:");

int najlepszy = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{marki[i]} {modele[i]}");
    Console.WriteLine($"Dystans: {dystanse[i]} km");
    Console.WriteLine($"Zużyte paliwo: {paliwo[i]} l");
    Console.WriteLine($"Średnie spalanie: {spalanie[i]:F2} l/100 km");
    Console.WriteLine();

    if (spalanie[i] < spalanie[najlepszy])
    {
        najlepszy = i;
    }
}

Console.WriteLine("Najbardziej ekonomiczny samochód:");
Console.WriteLine($"{marki[najlepszy]} {modele[najlepszy]} – {spalanie[najlepszy]:F2} l/100 km");
