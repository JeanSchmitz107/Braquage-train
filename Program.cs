using System.Security.Cryptography.X509Certificates;

namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin


        ... = rdn.next(1,2);
         */


        Console.WriteLine("Vous voulez choisir combient de wagon à explorer !!!");
        int Nbr_Wagon = Convert.ToInt32(Console.ReadLine());
        int Nbr_Coffre = 3;
        int Nbr_de_coffre_piller = 0;
        int Nbr_de_coffre_pièger = 0;
        for (int i_Wagon = 1; i_Wagon <= Nbr_Wagon; i_Wagon++)
        {
            Console.WriteLine("\n---------------------------------");
            for (int i_Coffre = 1; i_Coffre <= Nbr_Coffre; i_Coffre++)
            {
                Console.Write("|  Wagon " + i_Wagon + " - Coffre " + i_Coffre + " inspecté  |");
                if (i_Coffre == ((Nbr_Coffre / 2) + 1) && i_Wagon == 1)
                {
                    Console.WriteLine("            Le " + i_Wagon + "er wagon");
                }
                else if(i_Coffre == ((Nbr_Coffre / 2) + 1))
                {
                    Console.WriteLine("            Le " + i_Wagon + "éme wagon");
                }
                else
                {
                    Console.WriteLine("");
                }
                Nbr_de_coffre_piller ++;


                Random C_P = new Random();

                if (C_P.Next(10) == 1)
                {
                    Nbr_de_coffre_pièger ++;
                }
            }
            Console.Write("---------------------------------\n");
            if ((i_Wagon + 1) <= Nbr_Wagon)
            {
                Console.Write("              |--|\n              |--|");
            }
            
        }
        Console.Write("\nVous avez piller " + Nbr_de_coffre_piller + " coffres !\nDont " + Nbr_de_coffre_pièger + " de coffres pièger !\n");
        Console.Write("\nVotre butin est donc de " + (Nbr_de_coffre_piller - Nbr_de_coffre_pièger) + " trésores !!!\n");

    }
}