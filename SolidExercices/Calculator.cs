using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal resultat = 0;

            if (operation.Contains('+'))
            {
                string[] nombres = operation.Split('+');

                resultat = Convert.ToDecimal(nombres[0]);

                foreach (var nombre in nombres.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(nombre);
                }

                Console.WriteLine("Opération valide");
                return resultat;
            }
            else if (operation.Contains('*'))
            {
                string[] nombres = operation.Split('*');

                resultat = Convert.ToDecimal(nombres[0]);

                foreach (var nombre in nombres.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(nombre);
                }

                Console.WriteLine("Opération valide");
                return resultat;
            }
            else if (operation.Contains('/'))
            {
                string[] nombres = operation.Split('/');

                resultat = Convert.ToDecimal(nombres[0]);

                foreach (var nombre in nombres.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(nombre);
                }

                Console.WriteLine("Opération valide");
                return resultat;
            }
            else if (operation.Contains('-'))
            {
                string[] nombres = operation.Split('-');

                resultat = Convert.ToDecimal(nombres[0]);

                foreach (var nombre in nombres.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(nombre);
                }

                Console.WriteLine("Opération valide");
                return resultat;
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