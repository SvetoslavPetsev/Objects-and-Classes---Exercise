using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    public class Advertisement
    {
        public Advertisement(string phrase, string events, string author, string sity)
        {
            adv = phrase + " " + events + " " + author + " " + sity;
        }

        public string phrase { get; set; }
        public string events { get; set; }
        public string author { get; set; }
        public string sity { get; set; }

        public string adv;

    }
    class Program
    {
        static void Main()
        {
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> author = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> sity = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberVariation = int.Parse(Console.ReadLine());

            Random ph = new Random();
            Random ev = new Random();
            Random aut = new Random();
            Random sit = new Random();

            for (int i = 0; i < numberVariation; i++)
            {
                int randIndexPh = ph.Next(0, phrases.Count);
                int randIndexEv = ev.Next(0, events.Count);
                int randIndexAut = aut.Next(0, author.Count);
                int randIndexSit = sit.Next(0, sity.Count);

                Advertisement newAdves = new Advertisement(phrases[randIndexPh], events[randIndexEv], author[randIndexAut], sity[randIndexSit]);

                Console.WriteLine(newAdves.adv);
            }
        }
    }
}
