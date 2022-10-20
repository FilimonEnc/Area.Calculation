using Area.Calculation.Models.Circle;
using Area.Calculation.Models.Triangle;

namespace Area.Calculation.Figures
{
    public class Circle
    {
        public double S;
        public double R;
        public double Pi = Math.PI;

        public double CircleCalculation(CircleModel circleModel)
        {
           return ((UniversalCircleModel)circleModel).CalculateCircle();
        }
    }
}
