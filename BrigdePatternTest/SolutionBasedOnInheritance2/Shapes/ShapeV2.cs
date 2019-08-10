using DrowingProgram2;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionBasedOnInheritance2.Shapes
{
    public abstract class ShapeV2 : IShape
    {
        private readonly DP2 _dp2;

        protected ShapeV2(DP2 dp2)
        {
            _dp2 = dp2;
        }

        public abstract void Drow();
    }
}
