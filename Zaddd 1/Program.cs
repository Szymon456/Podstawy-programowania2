using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaddd_1
//Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
//Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
//użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.
{
    internal class Program
    {
        struct Osoba
        {
            public string imie;
            public string nazwisko;
            public int rok_urodzenia;
            public Osoba(string imie, string nazwisko, int rok_urodzenia)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.rok_urodzenia = rok_urodzenia;
            }
        }
        static void Main(string[] args)
        {
            Osoba o;
            Console.WriteLine("Podaj imię:");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia:");
            o.rok_urodzenia = int.Parse(Console.ReadLine());
            Console.Write($" {o.imie}");
            Console.Write($" {o.nazwisko}");
            Console.Write($" {o.rok_urodzenia}");
        }
    }
}
