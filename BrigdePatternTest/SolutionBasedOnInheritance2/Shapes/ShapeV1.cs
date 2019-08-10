using DrowingProgram1;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBasedOnInheritance2.Shapes
{
    public abstract class ShapeV1 : IShape
    {
        private readonly DP1 _dp1;

        protected ShapeV1(DP1 dp1)
        {
            _dp1 = dp1;
        }

        public abstract void Drow();
    }
}
