using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineClass
    {
        public double calculateLength(double x1,double x2,double y1,double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
        public void checkEquality(double len1,double len2)
        {
            if (len1 == len2)
                Console.WriteLine("Length of both lines are equals");
            else
                Console.WriteLine("Length of both lines are not equals");
        }

        public void compareLines(double len1, double len2)
        {
            if (len1 < len2)
                Console.WriteLine("Length of first line is less than Length of second line");
            else if (len1 > len2)
                Console.WriteLine("Length of first line is greater than Length of second line");
            else
                Console.WriteLine("Length of both lines are not equals");
        }
    }
}
