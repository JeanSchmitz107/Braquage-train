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
         */

        for (int Nbr_Wagon = 1; Nbr_Wagon <= 3; Nbr_Wagon ++)
        {
            for (int Nbr_Coffre = 1; Nbr_Coffre <= 3; Nbr_Coffre++)
            {
                Console.WriteLine("Wagon " + Nbr_Wagon + " - Coffre " + Nbr_Coffre + " inspecté");
            }
        }

    }
}