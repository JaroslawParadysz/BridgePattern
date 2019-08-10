using DrowingProgram1;

namespace SolutionBasedOnInheritence1.Shapes.Impl
{
    public class RectangularV1 : IRectangular
    {
        //Tight coupling
        private readonly DP1 dp1;

        private int X1, X2, Y1, Y2;

        public RectangularV1(DP1 dp1)
        {
            this.dp1 = dp1;
        }

        public void Drow()
        {
            dp1.DrowALine(X1, X2, Y1, Y2);
        }
    }
}
