using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Aprendendo_CS04
{
    public class Program_POO001
    {
        static void Main (string [] args){

            double xA, xB, xC, yA, yB, yC;

            System.Console.WriteLine("Entre com as medidas do triangulo x: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triangulo y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC ) / 2.0;
            double areaX = Math.Sqrt(p*(p-xA)*(p-xB)*(p-xC));

             p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p*(p-yA)*(p-yB)*(p-yC));

            System.Console.WriteLine("Area X possui: " + areaX.ToString("F5"),CultureInfo.InvariantCulture);
            System.Console.WriteLine("Area Y possui: " + areaY.ToString("f5",CultureInfo.InvariantCulture));

            if(areaX > areaY){
                System.Console.WriteLine("Area X é maior ");
            } else{
                System.Console.WriteLine("Area Y é Maior");
            }

        }       
    }
}