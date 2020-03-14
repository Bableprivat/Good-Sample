using System;

namespace Sample03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const int NombreMagique = 5;
            
            Console.WriteLine("Bonjour !");
            

            try
            {
                Console.WriteLine("Entrer un entier.");
                String NbreUser = Console.ReadLine();
                int nbreUser = int.Parse(NbreUser);

                if (nbreUser > NombreMagique)
                {
                    Console.WriteLine("Ce nombre est trop grand");
                }
                else if (nbreUser < NombreMagique)
                {
                    Console.WriteLine("Ce nombre est trop petit");
                }
                else
                {
                    Console.WriteLine("Bravo vous avez trouver le nombre magique !");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Vous devez entrer des nombres entiers Svp");
            }
        }
    }
}
