using DrowingProgram2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBasedOnInheritence1.Shapes.Impl
{
    public class RectangularV2 : IRectangular
    {
        //Tight coupling
        private readonly DP2 dp2;

        private int X1, X2, Y1, Y2;

        public RectangularV2(DP2 dp2)
        {
            this.dp2 = dp2;
        }

        public void Drow()
        {
            dp2.Drow_A_Line(X1, Y1, X2, Y2);
        }
    }
}
