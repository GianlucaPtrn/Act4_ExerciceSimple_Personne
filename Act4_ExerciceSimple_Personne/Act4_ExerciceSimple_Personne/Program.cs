using System;
using System.Diagnostics;
using System.Reflection;

namespace Act4_ExerciceSimple_Personne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans notre gestionnaire de porte monaie");
            Personne[] personnes = new Personne[2];
            personnes[0] = new Personne("", 0);
            personnes[1] = new Personne("", 0);

            Console.WriteLine("");

            Console.WriteLine("Permière personne qu'elle est votre nom ?");
            personnes[0].Nom = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Encodez une somme d'argent !!");
            personnes[0].Euro = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Deuxième personne qu'elle est votre nom ?");
            personnes[1].Nom = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Encodez une somme d'argent !!");
            personnes[1].Euro = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(personnes[i].sentenceMoney(personnes[i]));
                Console.WriteLine("");
            }

            Console.WriteLine("");

            string reload = "oui";
            while(reload == "oui")
            {
                Console.WriteLine(personnes[0].Nom + " combien voulez vous donner à " + personnes[1].Nom);
                personnes[1].ReceiveMoney(double.Parse(Console.ReadLine()));
                personnes[0].GiveMoney(double.Parse(Console.ReadLine()));

                Console.WriteLine("");
                Console.WriteLine("Ajout effectué !!");

                Console.WriteLine(personnes[1].Nom + " combien voulez vous donner à " + personnes[0].Nom);
                personnes[0].ReceiveMoney(double.Parse(Console.ReadLine()));
                personnes[1].GiveMoney(double.Parse(Console.ReadLine()));

                Console.WriteLine("");
                Console.WriteLine("Ajout effectué !!");

                Console.WriteLine("");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(personnes[i].sentenceMoney(personnes[i]));
                    Console.WriteLine("");
                }

                Console.WriteLine("Voulez vous encore envoyer de l'argent ??? (oui - non)");
                reload = Console.ReadLine();
            }
            
        }
    }
}
    