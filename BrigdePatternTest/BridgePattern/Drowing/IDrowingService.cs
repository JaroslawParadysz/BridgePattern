using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Drowing
{/// <summary>
/// Comment on master
/// </summary>
    public interface IDrowingService
    {
        void DrowALine(int x1, int y1, int x2, int y2);
        void DrowACircle(int x, int y, int r);
    }
}
