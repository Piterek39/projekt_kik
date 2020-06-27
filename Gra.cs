using System;
using System.Collections.Generic;
namespace kik
{
    class Gra
    {
        public List<char[]> plansza=new List<char[]> ()
        {
           new char[]{' ',' ',' '},
           new char[] {' ',' ',' '},
            new char[]{' ',' ',' '}
            
        };

        public Gra(char gracz)
        {
            Gracz=gracz;
        }
        public char Gracz
        {
            get;
            set;
        }
        public void Wypisanie_tablicy() //funkcja wypisuje tablice
        {
            for (int rzad=0; rzad<3; rzad++)
            {
                Console.Write("| ");
                foreach (var item in this.plansza[rzad])
                {
                    Console.Write(item);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        private bool Sprawdzenie_miejsca(int rzad, int kolumna) //funkcja sprawdza poprawnosc wspolrzednych
        {
            bool ok=false;
            if(rzad>2 || kolumna>2||rzad<0||kolumna<0)
                return false;
            if(plansza[rzad][kolumna] !='X' && plansza[rzad][kolumna]!='O')
                ok=true;
        return ok;
        }
        private bool remis() //funkcja sprawdza czy nastapil remis
        {
             for (int rzad=0; rzad<3; rzad++)
            {
                for (int kolumna=0; kolumna<3; kolumna++)
                {
                    if(plansza[rzad][kolumna]!='X' && plansza[rzad][kolumna]!='O')
                        return false;
                }
                }
                    return true;
        }
        private bool wygrana() //funkcja sprawdza czy gracz wygral
        {
            //rzad
            if(plansza[0][0]==Gracz&&plansza[0][1]==Gracz&&plansza[0][2]==Gracz)
                return true;
            if(plansza[1][0]==Gracz&&plansza[1][1]==Gracz&&plansza[1][2]==Gracz)
                return true;
            if(plansza[2][0]==Gracz&&plansza[2][1]==Gracz&&plansza[2][2]==Gracz)
                return true;
           //kolumna     
            if(plansza[0][0]==Gracz&&plansza[1][0]==Gracz&&plansza[2][0]==Gracz)
                return true;
            if(plansza[0][1]==Gracz&&plansza[1][1]==Gracz&&plansza[2][1]==Gracz)
                return true;
            if(plansza[0][2]==Gracz&&plansza[1][2]==Gracz&&plansza[2][2]==Gracz)
                return true;
            //skos    
            if(plansza[0][0]==Gracz&&plansza[1][1]==Gracz&&plansza[2][2]==Gracz)
                return true;
            if(plansza[0][2]==Gracz&&plansza[1][1]==Gracz&&plansza[2][0]==Gracz)
                return true;   
        return false;      
        }
        public static char ZmianaTury(char aktualnygracz) //funkcja zmienia gracza
        {
            if(aktualnygracz=='X')
            {
                return 'O';
            }
            else 
            {
                return 'X';
            }
        }
        public bool gra1v1() // gra przeciwko innemu graczowi
        {
            bool koniecgry= false;
            int rzad=0;
            int kolumna=0;
            Wypisanie_tablicy();
            while(koniecgry==false)
            {
            Console.Write("Podaj rzad: ");
            int.TryParse(Console.ReadLine().Trim(),out rzad);
            Console.Write("Podaj kolumne: ");
            int.TryParse(Console.ReadLine().Trim(),out kolumna);
            while(!Sprawdzenie_miejsca(rzad,kolumna))
            {
            Console.WriteLine("Zle miejsce. Sprobuj ponownie");
            Console.Write("Podaj rzad: ");
            int.TryParse(Console.ReadLine().Trim(),out rzad);
            Console.Write("Podaj kolumne: ");
            int.TryParse(Console.ReadLine().Trim(),out kolumna);
            }
            plansza[rzad][kolumna]=Gracz;
            Console.Clear();
            Wypisanie_tablicy();
            if (wygrana())
            {
                Console.WriteLine("wygral gracz "+Gracz);
                koniecgry=true;
                Console.ReadKey();
                return true;
            }
            else if (remis())
            {
                Console.WriteLine("Remis");
                koniecgry=true;
                Console.ReadKey();
                return true;
            }
            Gracz=ZmianaTury(Gracz);
            }
            return false;
             
         }
     public bool gravskomputer() //gra przeciwko komputerowi
        {
            bool koniecgry= false;
            int rzad=0;
            int kolumna=0;
            Random rand1=new Random();
            Random rand2=new Random();
            Wypisanie_tablicy();
            while(koniecgry==false)
            {
            if(Gracz=='X')
            {Console.Write("Podaj rzad: ");
            int.TryParse(Console.ReadLine().Trim(),out rzad);
            Console.Write("Podaj kolumne: ");
            int.TryParse(Console.ReadLine().Trim(),out kolumna);
            while(!Sprawdzenie_miejsca(rzad,kolumna))
            {
            Console.WriteLine("Zle miejsce. Sprobuj ponownie");
            Console.Write("Podaj rzad: ");
            int.TryParse(Console.ReadLine().Trim(),out rzad);
            Console.Write("Podaj kolumne: ");
            int.TryParse(Console.ReadLine().Trim(),out kolumna);
            }
            plansza[rzad][kolumna]=Gracz;
            }
            else
            {
            rzad=rand1.Next(0,3);
            for(int i=0;i<5000;i++)
            kolumna=rand2.Next(0,3);
            while(!Sprawdzenie_miejsca(rzad,kolumna))
            {
            rzad=rand1.Next(0,3);
            for(int i=0;i<5000;i++)
            kolumna=rand2.Next(0,3);
            }
            plansza[rzad][kolumna]=Gracz;
            }
            if(Gracz!='X')
            Console.Clear();
            Wypisanie_tablicy();
            if (wygrana())
            {
                Console.WriteLine("wygral gracz "+Gracz);
                koniecgry=true; 
                Console.ReadKey();   
                return true;
            }
            else if (remis())
            {
                Console.WriteLine("Remis");
                koniecgry=true;
                Console.ReadKey();
                return true;
            }
            Gracz=ZmianaTury(Gracz);
            }
            return false;
            
         }
        
    }
}