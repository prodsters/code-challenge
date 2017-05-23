//Ogbonna Vitalis(sage94)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class QuadraticEquation
    {
        private double a,b,c;
        public double A
        { get   { return a; }
          set   { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double getDiscriminant()
        {
           double getDiscriminant = (b * b) - (4 * a * c);
           return getDiscriminant;
        }
        public  void checkDiscriminant()
        {
            double getDiscriminant = (b * b) - (4 * a * c);
            if (getDiscriminant < 0)
            {
                Console.WriteLine( "The Equation Has No Roots");
            }
        }
        public double getRoot1()
        {
            double give = getDiscriminant();
            if (give < 0)
            {
                return 0;
            }
            else
            {
                double getRoot1 = -b + Math.Sqrt(give);
                getRoot1 = getRoot1 / (2 * a);
                return getRoot1;
            }
        }


        public double getRoot2()
        {
            double give2 = getDiscriminant();
            if (give2 < 0)
            {
                return 0;
            }
            else
            {
                double getRoot2 = -b - Math.Sqrt(give2);
                getRoot2 = getRoot2 / (2 * a);
                return getRoot2;
            }
        }
    }

}
