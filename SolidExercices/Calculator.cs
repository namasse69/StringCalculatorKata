using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            var operateurs = new List<IOperateur>();
            operateurs.Add(new Addition());
            operateurs.Add(new Produit());
            operateurs.Add(new Division());
            operateurs.Add(new Soustraction());

            foreach (var operateur in operateurs)
            {
                if(operateur.PeutCalculer(operation))
                {
                    return operateur.Calcul(operation);
                }       
            }
            
            Console.WriteLine("Opération non valide");
            return 0;
        }
    }
}