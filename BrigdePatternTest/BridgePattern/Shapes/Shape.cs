using BridgePattern.Drowing;

namespace BridgePattern.Shapes
{
    public abstract class Shape
    {
        protected IDrowingService _drowingService;

        protected Shape(IDrowingService drowingService)
        {
            _drowingService = drowingService;
        }

        public abstract void Drow();
    }
}
