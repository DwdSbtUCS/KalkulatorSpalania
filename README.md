# Muli Car Care

Edukacyjna aplikacja konsolowa w C# obsługująca trzy samochody. Dane przechowywane są w tablicach, bez tworzenia własnych klas.

## Funkcje

- Pobieranie marki, modelu, dystansu i zużytego paliwa.
- Obliczanie spalania każdego pojazdu w l/100 km.
- Wyświetlanie danych i wskazanie najbardziej ekonomicznego samochodu.
- Sprawdzanie, czy dystans jest dodatni, a ilość paliwa nieujemna.

## Uruchomienie

Wymagany .NET SDK 8.0. W folderze projektu wykonaj:

```bash
dotnet run
```

Liczby dziesiętne wpisuj z przecinkiem.

## Przykład

Dla każdego samochodu podaj dystans 100 km:

| Samochód | Zużyte paliwo | Spalanie |
|---|---:|---:|
| Toyota Corolla | 6,2 l | 6,20 l/100 km |
| Ford Focus | 7,1 l | 7,10 l/100 km |
| Skoda Octavia | 5,9 l | 5,90 l/100 km |

Najbardziej ekonomiczny samochód: Skoda Octavia — 5,90 l/100 km.

## Zagadnienia

Programowanie proceduralne, tablice, pętle, instrukcje warunkowe, konwersja danych i wyszukiwanie najmniejszej wartości.

## Ograniczenia i weryfikacja

Program obsługuje dokładnie trzy samochody. Przy remisie wskazuje pierwszy. Zakłada poprawny zapis liczb; tekst zamiast liczby może spowodować wyjątek. Dane istnieją tylko podczas działania programu.

Kompilację oraz powyższy przykład sprawdzono na Linuxie z .NET SDK 8.0.

Autor: Dawid Sobota.
