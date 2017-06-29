using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Produit : IOperateur
    {
        public bool PeutCalculer(string operation)
        {
            return operation.Contains('*');
        }


        public decimal Calcul(string operation)
        {
            string[] nombres = operation.Split('*');

            var resultat = Convert.ToDecimal(nombres[0]);

            foreach (var nombre in nombres.Skip(1).ToArray())
            {
                resultat *= Convert.ToDecimal(nombre);
            }

            return resultat;
        }
    }
}
