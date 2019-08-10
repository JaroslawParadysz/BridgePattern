using System;
using System.Collections.Generic;
using System.Text;
using BridgePattern.Drowing;

namespace BridgePattern.Shapes.Impl
{
    public class Circle : Shape
    {
        private int x, y, r;
        public Circle(IDrowingService drowingService) : base(drowingService)
        {
        }

        public override void Drow()
        {
            _drowingService.DrowACircle(x, y, r);
        }
    }
}
