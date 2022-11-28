using System;

namespace Act4_ExerciceSimple_Personne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans notre gestionnaire de porte monaie");
            Personne[] personnes = new Personne[2];
            personnes[0] = new Personne("volt", 0);
            personnes[1] = new Personne("Rox", 0);

            Console.WriteLine("Permière personne qu'elle est votre nom ?");
            personnes[0].Nom = Console.ReadLine();
            Console.WriteLine("Encodez une somme d'argent !!");
            personnes[0].Euro = int.Parse(Console.ReadLine());

            Console.WriteLine("Permière personne qu'elle est votre nom ?");
            personnes[1].Nom = Console.ReadLine();
            Console.WriteLine("Encodez une somme d'argent !!");
            personnes[1].Euro = int.Parse(Console.ReadLine());


            personnes[0] = new Personne(personnes[0].Nom, personnes[0].Euro);
            personnes[1] = new Personne(personnes[1].Nom, personnes[1].Euro);

            Console.WriteLine(personnes[0].sentenceMoney());
        }
    }
}
    