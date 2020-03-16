using System;

namespace Sample04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");           

            try
            {
                const int NombreMagique = 5;
                Console.WriteLine("Bonjour !");
                Console.WriteLine("Entrez un nombre entier Svp !");
               
                const int NombreDevie = 4;

              for(int i = 0; i < NombreDevie; i++)
                {
                    String NombreUser = Console.ReadLine();
                    int nombreUser = int.Parse(NombreUser);

                    if (nombreUser > NombreMagique)
                    {
                        Console.WriteLine("Le nombre entré est  trop grand");
                    }
                    else if(nombreUser < NombreMagique)
                    {
                        Console.WriteLine("Le nombre entré est trop petit");
                    }
                    else
                    {
                        Console.WriteLine("Bravo vous avez trouver le nombre magique !");
                    }
                    Console.WriteLine(" Entrez un nombre encore ");
                }
                
                Console.WriteLine("Vous avez perdu");
            }
            catch (Exception)
            {
                Console.WriteLine("Vous devez entrez un nombre entier Svp  !");
            }
        }
    }
}
