﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Division : IOperateur
    {
        public bool PeutCalculer(string operation)
        {
            return operation.Contains('/');
        }


        public decimal Calcul(string operation)
        {
            string[] nombres = operation.Split('/');
            
            try
            {
                var resultat = Convert.ToDecimal(nombres[0]);

                foreach (var nombre in nombres.Skip(1).ToArray())
                {
                        resultat /= Convert.ToDecimal(nombre);
                
                }

                return resultat;
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentOutOfRangeException("Attetion division par zéro");
            }
            catch (FormatException)
            {
                throw new ArgumentException("Format incorrect");
            }
        }
    }
}
