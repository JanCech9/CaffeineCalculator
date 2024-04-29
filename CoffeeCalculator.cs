using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeCounter
{
  public static class CoffeeCalculator
  {
    public const double EsCoef = ((float)212 / 100), V60Coef = ((float)145 / 240);
    public static double CalculateCaffeine(double es = 0, double v60 = 0)
    {
      double total = EsMl2Mg(es) + V60Ml2Mg(v60); 

      return total;
    }

    public static double EsMl2Mg(double ml)
    {
      double mg = ml * EsCoef;

      return mg;
    }

    public static double V60Ml2Mg(double ml)
    {
      double mg = ml * V60Coef;
      
      return mg;
    }
  }
}
