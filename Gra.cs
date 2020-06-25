using System;

namespace kik
{
    class Gra
    {
        static int [,] tablica;

         public static void Tablica()
         {
               for (int rzad=0; rzad<3; rzad++)
            {
                for (int kolumna=0; kolumna<3; kolumna++)
                {
                    tablica[rzad,kolumna]=' ';
                }
         }
         Wypisanie_tablicy();
         }
        private static void Wypisanie_tablicy()
        {
            for (int rzad=0; rzad<3; rzad++)
            {
                Console.Write("| ");
                for (int kolumna=0; kolumna<3; kolumna++)
                {
                    Console.Write(tablica[rzad,kolumna]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        private bool Sprawdzenie_miejsca(int rzad, int kolumna)
        {
            bool ok=false;
            if(rzad>3 || kolumna>3)
                return false;
            if(tablica[rzad,kolumna] !='X' && tablica[rzad,kolumna]!='O')
                ok=true;
                return ok;
        }
    }
}