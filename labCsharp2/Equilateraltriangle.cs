using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labCsharp2
{
    class Equilateraltriangle : Triangle
    {
 
        public Equilateraltriangle()
        {
        }

        public Equilateraltriangle(double firstside, double secondside, double thirdtside)
        {
            base.Firstside = firstside;
            base.Secondside = secondside;
            base.Thirdtside = thirdtside;
        }
         
        public string Equilateral()
        {
            if ((Firstside == Secondside) && (Secondside == Thirdtside)) return "Треугольник равносторнний".ToString();
            else
            {
               return "Треугольник не равносторнний".ToString();
            }
        }
        public String Ec()
        {
            return this.Equilateral();
        }
    }  
}

