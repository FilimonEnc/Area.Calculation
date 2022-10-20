namespace Area.Calculation.Models.Triangle
{
    public abstract class TriangleModel
    {
        public double A { get; set; } // первая сторона треугольника
        public double B { get; set; } // вторая сторона треугольника
        public double C { get; set; } // третья сторона треугольника
        public double p { get; set; } // полупериметр треугольника
        public double S { get; set; } // площадь треугольника

        public abstract double CalculateTriangle();
    }
}
