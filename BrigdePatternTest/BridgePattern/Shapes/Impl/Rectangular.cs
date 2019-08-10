using System;
using System.Collections.Generic;
using System.Text;
using BridgePattern.Drowing;

namespace BridgePattern.Shapes.Impl
{
    public class Rectangular : Shape
    {
        private int x1, y1, x2, y2;
        public Rectangular(IDrowingService drowingService) : base(drowingService)
        {
        }

        public override void Drow()
        {
            _drowingService.DrowALine(x1, y1, x2, y2);
        }
    }
}
