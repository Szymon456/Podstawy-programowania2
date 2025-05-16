using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadd_2
//Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
//Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
//umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
//Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
{
    internal class Program
    {
        struct uczeń
        {
            public string imie;
            public string nazwisko;
            public int[] oceny;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę uczniów:");
            int liczbaUczniów = int.Parse(Console.ReadLine());
            uczeń[] uczniowie = new uczeń[liczbaUczniów];
            for (int i = 0; i < liczbaUczniów; i++)
            {
                Console.WriteLine($"Podaj imię ucznia {i + 1}:");
                uczniowie[i].imie = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko ucznia {i + 1}:");
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.WriteLine($"Podaj liczbę ocen dla ucznia {i + 1}:");
                int liczbaOcen = int.Parse(Console.ReadLine());
                uczniowie[i].oceny = new int[liczbaOcen];
                for (int j = 0; j < liczbaOcen; j++)
                {
                    Console.WriteLine($"Podaj ocenę {j + 1} dla ucznia {i + 1}:");
                    uczniowie[i].oceny[j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nDane uczniów:");
            for (int i = 0; i < liczbaUczniów; i++)
            {
                Console.WriteLine($"Uczeń {i + 1}: {uczniowie[i].imie} {uczniowie[i].nazwisko}");
                Console.Write("Oceny: ");
                foreach (var ocena in uczniowie[i].oceny)
                {
                    Console.Write(ocena + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
