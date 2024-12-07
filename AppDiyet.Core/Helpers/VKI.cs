using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;

namespace AppDiyet.Core.Helpers
{
    public class VKI 
    {
        public static double CalculateVki(double lenght, double weight)
        {  
            double vki = weight / Math.Pow((lenght / 100 ), 2);

            return vki;
        }
    }
}
