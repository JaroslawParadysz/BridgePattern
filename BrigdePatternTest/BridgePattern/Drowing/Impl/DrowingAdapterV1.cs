using DrowingProgram1;

namespace BridgePattern.Drowing.Impl
{
    public class DrowingAdapterV1 : IDrowingService
    {
<<<<<<< HEAD
        private readonly DP1 _dp1, dp;
=======
        private readonly DP1 _dp, _dp1;
>>>>>>> changes

        public DrowingAdapterV1()
        {
            _dp = new DP1();
        }

        public void DrowACircle(int x, int y, int r)
        {
            _dp.DrowACircle(x,y,r);
        }

        public void DrowALine(int x1, int y1, int x2, int y2)
        {
            _dp.DrowALine(x1,y1=x2,y1,y2);
        }
    }
}
