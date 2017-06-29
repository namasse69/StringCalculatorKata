using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal resultat = 0;
            Addition addition = new Addition();
            Produit produit = new Produit();
            Division division = new Division();
            Soustraction soustraction = new Soustraction();

            if (addition.PeutCalculer(operation))
            {
                return addition.Calcul(operation);
            }
            else if (produit.PeutCalculer(operation))
            {
                return produit.Calcul(operation);
            } 
            else if (division.PeutCalculer(operation))
            {
                return division.Calcul(operation);
            } 
            else if (soustraction.PeutCalculer(operation))
            {
                return soustraction.Calcul(operation);
            }
            else
            {
                Console.WriteLine("Opération non valide");
                return 0;
            }
            return resultat;
        }
    }
}