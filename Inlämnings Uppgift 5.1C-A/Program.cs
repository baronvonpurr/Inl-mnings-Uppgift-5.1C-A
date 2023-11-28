using System;

namespace Uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[3];

            meningar[0] = "Jag älskar att programmera";
            meningar[1] = "Det är så kul att göra";
            meningar[2] = "Jag hoppas att få jobba med programmering i framtiden";

            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(meningar[i]);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}