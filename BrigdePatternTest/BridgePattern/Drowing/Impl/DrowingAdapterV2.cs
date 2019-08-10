using DrowingProgram2;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Drowing.Impl
{
    class DrowingAdapterV2 : IDrowingService
    {
        private readonly DP2 _dp1;

        public DrowingAdapterV2()
        {
            _dp1 = new DP2();
        }

        public void DrowACircle(int x, int y, int r)
        {
            _dp1.Drow_A_Circle(x, y, r);
        }

        public void DrowALine(int x1, int y1, int x2, int y2)
        {
            _dp1.Drow_A_Line(x1, y1, x2, y2);
        }
    }
}
