using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineLengthComparison
{
    public class LineLengthComputation
    {
        public double CalculateLength(int x1, int y1, int x2, int y2)
        {
            double length = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
            return length;
        }
        public void Compare(int a1, int b1, int c1, int a2, int b2, int c2)
        {

            // Function to check if they are equal
            double length1 = this.CalculateLength(a1, b1, a2, b2);
            double length2 = this.CalculateLength(c1, a1, c2, a2);

            if (length1 == length2)
                Console.WriteLine("The given straight" + " lines are equal");
            else
                Console.WriteLine("The given straight" + " lines are not equal");
        }
    }
}

