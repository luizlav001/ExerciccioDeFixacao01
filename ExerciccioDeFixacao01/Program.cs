using System;
using System.Globalization;

namespace ExerciccioDeFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaP = p.Area();
            double perimetroP = p.Perimetro();
            double diagonalP = p.Diagonal();

            Console.WriteLine("AREA = " + areaP.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO  = " + perimetroP.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonalP.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
