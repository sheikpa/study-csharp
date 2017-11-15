using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_6
{
    class Fraction
    {
        public double child, mother;

        public Fraction(double child, double mother)
        {
            this.child = child;
            this.mother = mother;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            double child = a.child * b.mother + b.child * a.mother;
            double mother = a.mother * b.mother;
            double child1, child2;

            if (child % mother == 0)
            {
                mother = child / mother;
                child = 0;
            }
            else
            {
                for (int i = 10; i > 1; i--)
                {
                    if (child % i == 0 &&
                        mother % i == 0)
                    {
                        child = child / i;
                        mother = mother / i;
                    }
                }
                if (child > mother)
                {
                    child1 = Math.Round(child / mother, 1);
                    if (child1.ToString().IndexOf(".") > -1)
                    {
                        int i = child1.ToString().IndexOf(".");
                        child1 = int.Parse(child1.ToString().Substring(0, i));
                    }
                    child2 = child - (mother * child1);
                    child = double.Parse(child1.ToString() + "." + child2.ToString());
                }
            }

            return new Fraction(child, mother);
        }
    }
}
