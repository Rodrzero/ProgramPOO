using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendendo_CS04
{
    public class Triangulo
    {
        public Double A;
        public Double B;
        public Double C;

    
        public double Area(){
            double p = (A +B +C) / 2.0;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));


        }


    }
}