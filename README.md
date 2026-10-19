# Kalkulator spalania

Prosta aplikacja konsolowa w C#, która oblicza średnie zużycie paliwa na podstawie przejechanego dystansu i liczby zużytych litrów.

## Funkcje

- Wczytywanie danych z klawiatury.
- Obliczanie spalania: paliwo / dystans × 100.
- Wynik z dwoma miejscami po przecinku.
- Odrzucenie niedodatniego dystansu i ujemnej ilości paliwa.

## Uruchomienie

Wymagany .NET SDK 8.0. W katalogu projektu uruchom:

```bash
dotnet run
```

## Przykład

```text
Podaj przejechany dystans [km]: 450
Podaj zużyte paliwo [l]: 31
Średnie spalanie: 6,89 l/100 km
```

Liczby dziesiętne wpisuj z przecinkiem, np. `31,5`.

## Zastosowane zagadnienia

Zmienne typu double, Console.ReadLine, konwersja typów, działania matematyczne, instrukcje warunkowe i formatowanie wyniku. Rozwiązanie proceduralne — klasa Program służy jako punkt wejścia aplikacji.

## Zakres

Projekt edukacyjny. Zakłada poprawny zapis liczb — wpisanie tekstu zamiast liczby może spowodować wyjątek. Dane nie są zapisywane do pliku. Kompilację i przykład sprawdzono na Linuxie z .NET SDK 8.0.

Autor: Dawid Sobota.
