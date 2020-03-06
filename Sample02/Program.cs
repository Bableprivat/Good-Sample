using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample02
{
    class Program
    {
        

        public static void cestFini()
        {
            List<int> prix = new List<int>();
            Console.WriteLine("Bobjour !");
            String rep = "o";
            while(rep != "n")
            {
                Console.WriteLine("Entrez seulement des prix sans fcfa");
                String saisie = Console.ReadLine();
                int conversion = int.Parse(saisie);
                prix.Add(conversion);
                Console.WriteLine("Voulez vous entrez un nouveau prix?");
                rep = Console.ReadLine();
            }

            //somme
            int somme = 0;
            for (int i = 0; i < prix.Count; i++)
            {
                somme += prix[i];
            }

            //affichage
            Console.WriteLine(somme);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            cestFini();
            Console.ReadKey();

        }
    }
}
