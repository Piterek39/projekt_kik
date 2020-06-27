using System;

namespace kik
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Gra test=new Gra('X');
                Console.Clear();
                Console.WriteLine("Kolko i krzyzyk");
                Console.WriteLine("1- Gra przeciwko drugiej osobie");
                Console.WriteLine("2- Gra przeciwko komputerowi");
                Console.WriteLine("3-Wyjscie z aplikacji");
                ConsoleKeyInfo klawisz =Console.ReadKey();
                switch(klawisz.Key)
                {
                    case ConsoleKey.D1:
                    Console.Clear(); test.gra1v1(); break;
                    case ConsoleKey.D2:
                    Console.Clear(); test.gravskomputer(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0); break;
                    default:break;
                }


            }
        }
    }
}
