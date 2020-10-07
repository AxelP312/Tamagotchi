using System.Xml;
using System;
using System.Threading;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            tamagotchi spelare = new tamagotchi();

            bool Alive = true;
            bool Talkable = false;
            string svar = "";

            System.Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            while (Alive == true)
            {
                Alive = spelare.GetAlive();
                spelare.Tick();
                Console.WriteLine("What do you want to do? \n[1]Feed\n[2]Talk\n[3]Teach\n[4]Stats\n[5]Skip");
                svar = Console.ReadLine().ToLower();

                if (svar == "feed")
                {
                    spelare.Feed();
                    Console.WriteLine("Nom nom nom");
                }
                else if (svar == "talk")
                {
                    if(Talkable == true)
                    {
                        System.Console.Write(name + " said ");
                        spelare.Hi();

                    }
                    else
                    {
                        Console.WriteLine("I don't know any words");
                    }
                }
                else if (svar == "teach")
                {
                    System.Console.WriteLine("What new word do you want to learn?");
                    string nyttOrd = Console.ReadLine();
                    spelare.Teach(nyttOrd);
                    Console.WriteLine(name + " learned the word " + nyttOrd);
                    Talkable = true;


                }
                else if (svar == "stats")
                {
                    spelare.PrintStats();
                }
                else if (svar == "skip")
                {}
                else
                {
                    Console.WriteLine("Write one of the alternatives)");
                    svar = Console.ReadLine().ToLower();
                }
                Thread.Sleep(500);
                Console.Clear();
            }

            System.Console.WriteLine("You died :)");
        }
    }
}
