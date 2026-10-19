using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pl-PL");

        Console.Write("Podaj przejechany dystans [km]: ");
        double dystans = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj zużyte paliwo [l]: ");
        double paliwo = Convert.ToDouble(Console.ReadLine());

        if (dystans <= 0)
        {
            Console.WriteLine("Błąd: dystans musi być większy od 0.");
        }
        else if (paliwo < 0)
        {
            Console.WriteLine("Błąd: ilość paliwa nie może być ujemna.");
        }
        else
        {
            double spalanie = paliwo / dystans * 100;
            Console.WriteLine($"Średnie spalanie: {spalanie:F2} l/100 km");
        }
    }
}
