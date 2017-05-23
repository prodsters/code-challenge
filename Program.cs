//Ogbonna Vitalis(Sage94)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me equations in the form:ax2 + bx + c");
            double input1 =double.Parse(Console.ReadLine());
            Console.WriteLine("a :" + input1);
            double input2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("b :" + input2);
            double input3 = double.Parse(Console.ReadLine());

            QuadraticEquation Vita = new QuadraticEquation();
            Vita.A = input1;
            Vita.B = input2;
            Vita.C = input3;

            //check the determinant
            Vita.checkDiscriminant();

            //get the determinant
            Vita.getDiscriminant();
           double firstRoot= Vita.getRoot1();   
           double secondRoot=Vita.getRoot2();

            Console.WriteLine("The Roots are " + firstRoot +" and " + secondRoot);
            Console.ReadKey();


        }
    }
}
