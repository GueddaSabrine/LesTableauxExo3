using System;
using System.Collections.Generic;
using System.Linq;

namespace LesTableauxExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Créer une liste numbers et la remplir de nombres au choix.
            À l’aide d’une boucle, calculer la somme de tous les nombres de la liste.
            Afficher le résultat dans une phrase.
            Bonus: rappelez tous les nombres dans le calcul.*/

            int result = 0;
            List<int> number = new List<int>() { 10, 20, 30, 50};

            result = number.Sum();

            Console.WriteLine($"le résultat de ton addition est de {result}");

            
            string usedNumber = String.Join(" + ", number);
            Console.WriteLine(usedNumber);



            /*List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };//
           // Console.WriteLine("liste  : ");

            
            int sum = 0;//

            sum = numbers.Sum();
            Console.WriteLine($"résulat {sum}");

            string usedNumbers = String.Join(" + ", numbers);
            Console.WriteLine("usedNumbers");*/


            /*for (int i = 0; i < numbers.Count; i++)
            {
                somme = start + numbers[i];
                Console.WriteLine($"calcul avec le résultat précédent {i} :  {start} + {numbers[i]} = {somme}");
                start = somme;
            }*/
            //Console.WriteLine($"résulat {somme}");
        }
    }
}
