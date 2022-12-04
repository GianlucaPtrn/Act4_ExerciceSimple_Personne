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

        public double GiveMoney(Personne[] personnes, double money){
            double giveMoney = 0;
            if (_euro < money){
                giveMoney = _euro - money;
            }
            else{
                Console.WriteLine("Probleme !! SOLDE INSUFFISANT");
            }
            return giveMoney;
        }

        public void ReceiveMoney(double giveMoney){
            double receiveMoney = _euro + giveMoney;
        }


        public string sentenceMoney(Personne personnes)
        {
            string sentence = _nom + " a " + _euro + " euro dans son porte-feuille";
            return sentence;
        }
    }
}
