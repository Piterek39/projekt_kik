using System;

namespace kik
{
    class Gra
    {
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
    }
}