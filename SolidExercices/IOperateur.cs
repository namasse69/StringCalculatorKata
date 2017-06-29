using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public interface IOperateur
    {
        bool PeutCalculer(String operation);
        decimal Calcul(String operation);
    }
}
