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

            Triangulo y , x;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaX = x.Area();

        
            double areaY = y.Area();

            System.Console.WriteLine("Area X possui: " + areaX.ToString("F5"),CultureInfo.InvariantCulture);
            System.Console.WriteLine("Area Y possui: " + areaY.ToString("f5",CultureInfo.InvariantCulture));

            if(areaX > areaY){
                System.Console.WriteLine("Area X é maior ");
            } else{
                System.Console.WriteLine("Area Y é maior");

            }

        }       
    }
}