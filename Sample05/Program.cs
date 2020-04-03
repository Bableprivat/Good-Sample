using System;

namespace Sample05
{
    class Program
    {
        //private static int nbreUser;

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Bonjour.\nEntrez un entier entre 3 et 10 SVP !");

            int NombreDevie = 4;
            var random = new Random();

            try
            {

                //for (int i = 0; i < NombreDevie; i++)
                
                while(NombreDevie != 0)
                {
                    String saisie = Console.ReadLine();
                    int nbreUser = int.Parse(saisie);

                    //Console.WriteLine(random.Next(3, 10));

                    if (!((3 <= nbreUser) && (nbreUser <= 9)))
                    {
                        // on lui dit ça
                        Console.WriteLine("Veuillez entrez un nombre compris entre 3 et 9 ");
                    }
                    else
                    {
                        /*if (nbreUser > random.Next(3, 10))
                        {
                            Console.WriteLine("Le nombre est trop grand");
                        }
                        else if (nbreUser < random.Next(3, 10))
                        {
                            Console.WriteLine("Le nombre est trop petit");
                        }
                        else
                        {
                            Console.WriteLine("Bravo vous avez trouver le nombre Magique");
                        }
                        Console.WriteLine("Entrer un nombre à nouveau svp");*/

                        if (nbreUser == random.Next(3, 10))
                        {
                            Console.WriteLine("Félicitation vous avez trouvez le nombre magique");
                            break;
                        }
                        else
                        {
                            if (NombreDevie == 1)
                            {
                                Console.WriteLine("Vous avez perdu, vous avez  atteint votre chance!");
                            }
                            else
                            {
                                if (nbreUser > random.Next(3, 10))
                                {
                                    Console.WriteLine("Dommage réessayer, Le nombre est trop grand ");
                                }
                                else
                                {
                                    Console.WriteLine("Dommage réessayer, Le nombre entré est trop petit ");
                                }
                            }
                        }
                    }
                    
                    NombreDevie--;

                }
                

            //Vérifie si lenombre entrer est un entier
            }
            catch (Exception)
            {
                Console.WriteLine("Vous devez entrer un nombre entier svp");
            }
            
        }
    }
}
