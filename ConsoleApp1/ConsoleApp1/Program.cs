using System;
using System.Collections.Generic;
using System.Numerics;

namespace RootsCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Complex> rootsWithinRange = FindRootsWithinRange();

            Console.WriteLine("1 < |z| < 5 aralığında bulunan kökler:");
            foreach (Complex root in rootsWithinRange)
            {
                Console.WriteLine(root);
            }
        }

        static List<Complex> FindRootsWithinRange()
        {
            List<Complex> roots = new List<Complex>();

            // Denklemi çözme
            var polynomial = new Polynomial(new Complex[] { 36, -2, 13, -2, 1 });
            var solver = new LaguerreSolver();
            var rootResults = solver.FindAllRoots(polynomial, new Complex(0, 0));

            // Kökleri kontrol etme
            foreach (var result in rootResults)
            {
                if (result.Imaginary == 0 && result.Magnitude > 1 && result.Magnitude < 5)
                {
                    roots.Add(result);
                }
            }

            return roots;
        }
    }
}