﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int child1 = rnd.Next(1, 11);
            int mother1 = rnd.Next(1, 11);
            int child2 = rnd.Next(1, 11);
            int mother2 = rnd.Next(1, 11);

            Fraction fraction1 = new Fraction(child1, mother1);
            Fraction fraction2 = new Fraction(child2, mother2);

            Fraction fraction1cons = Fraction.consoleFraction(fraction1.child, fraction1.mother);
            Fraction fraction2cons = Fraction.consoleFraction(fraction2.child, fraction2.mother);

            consoleWrite(fraction1cons.child, fraction1cons.mother);
            Console.Write(" + ");

            consoleWrite(fraction2cons.child, fraction2cons.mother);
            Console.Write(" = ");

            Fraction fraction3 = fraction1 + fraction2;
            consoleWrite(fraction3.child, fraction3.mother);
        }

        public static void consoleWrite(double child, double mother)
        {
            if (child == 0)
            {
                Console.Write("{0}", mother);
            }
            else
            {
                Console.Write("{0}/{1}", child, mother);
            }
        }
    }
}
