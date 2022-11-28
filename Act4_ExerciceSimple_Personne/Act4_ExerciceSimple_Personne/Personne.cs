using System;
using System.Collections.Generic;
using System.Text;

namespace Act4_ExerciceSimple_Personne
{
    class Personne
    {
        private string _nom;
        private double _euro;

        public string Nom
        {
            get{
                return _nom; 
            }
            set{
                _nom = value; 
            }
        }

        public double Euro
        {
            get{
                return _euro;
            }
            set{
                _euro = value;
            }
        }

        public Personne(string nom, double euro){
            _nom = nom;
            _euro = euro;
        }

        public double GiveMoney(Personne[] personnes ){
            Console.WriteLine(personnes[0].Nom + " combien Voulez vous donner à " + personnes[1].Nom);
            Console.WriteLine("Encodez une somme d'argent !!");
            double money = double.Parse(Console.ReadLine());
            double giveMoney = _euro - money;
            return giveMoney;
        }

        public double ReceiveMoney(double giveMoney)
        {
            double receiveMoney = _euro + giveMoney;
            Console.WriteLine("Ajout effectué !!");
            return receiveMoney;
        }

        public string sentenceMoney(Personne[] personnes, double giveMoney, double receiveMoney)
        {
            string sentence = "";
            for(int i = 0; i < 2; i++)
            {
                sentence = personnes[i].Nom + " a " + _euro + " euro dans son porte-feuille";
            }
            return sentence;
        }
    }
}
