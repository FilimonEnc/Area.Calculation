namespace Area.Calculation.Models.Circle
{
    public abstract class CircleModel
    {
        public double r { get; set; } // радиус круга
        public double S { get; set; } // площадь круга
        public abstract double CalculateCircle();
    }
}
