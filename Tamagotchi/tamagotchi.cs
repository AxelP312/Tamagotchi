using System.Net;
using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class tamagotchi
    {
        private int hunger;
        private int boredom;
        private bool isAlive = true;
        private Random generator = new Random();
        private List<string> words = new List<string>();

        public void Tick()
        {
            hunger++;
            boredom++;
            if(hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }
    	public void Feed()
        {
            if(hunger == 0 )
            {
                Console.WriteLine("You are not hungry");
            }
            else
            {
                hunger--;
            }
                
        }

        public void Hi()
        {
            int slumptal = generator.Next(words.Count);

            Console.Write(words[slumptal]);

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            
            ReduceBoredom();

        }
        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Alive? " + isAlive);
        }
        public bool GetAlive()
        {
            if(isAlive == false)
            {
                return isAlive = false;
            }
            else
            {
                return isAlive = true;
            }
        }

        private void ReduceBoredom()
        {
            boredom--;
        }

    }

}
