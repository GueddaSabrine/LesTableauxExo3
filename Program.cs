using System;
using System.Collections.Generic;

namespace LesTableauxExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Créer une liste numbers et la remplir de nombres au choix.
            //À l’aide d’une boucle, calculer la somme de tous les nombres de la liste.
            //Afficher le résultat dans une phrase.
            //Bonus: rappelez tous les nombres dans le calcul.

            //var numbers = new List<int> { 1, 2, 3, 4, 5 };

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("liste  : ");

            int start = 0;
            int somme = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                somme = start + numbers[i];
                Console.WriteLine($"calcul avec le résultat précédent {i} :  {start} + {numbers[i]} = {somme}");
                start = somme;
            }
            Console.WriteLine($"résulat {somme}");
        }
    }
}
