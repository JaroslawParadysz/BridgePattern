using DrowingProgram1;

namespace BridgePattern.Drowing.Impl
{
    public class DrowingAdapterV1 : IDrowingService
    {
        private readonly DP1 _dp1;

        public DrowingAdapterV1()
        {
            _dp1 = new DP1();
        }

        public void DrowACircle(int x, int y, int r)
        {
            _dp1.DrowACircle(x,y,r);
        }

        public void DrowALine(int x1, int y1, int x2, int y2)
        {
            _dp1.DrowALine(x1,y1=x2,y1,y2);
        }
    }
}
