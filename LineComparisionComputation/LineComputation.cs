using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineComputation
    {
        double pointX1, pointY1, pointX2, pointY2;
        public LineComputation(double pointX1, double pointY1, double pointX2, double pointY2)
        {
            this.pointX1 = pointX1;
            this.pointY1 = pointY1;
            this.pointX2 = pointX2;
            this.pointY2 = pointY2;
        }
        public double Length()
        {
            return Math.Sqrt((pointX2 - pointX1) * (pointX2 - pointX1) + (pointY2 - pointY1) * (pointY2 - pointY1));
        }
    }
}
