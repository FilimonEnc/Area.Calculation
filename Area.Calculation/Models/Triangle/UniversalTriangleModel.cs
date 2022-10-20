namespace Area.Calculation.Models.Triangle
{
    public class UniversalTriangleModel : TriangleModel
    {
        public override double CalculateTriangle()
        {
            p = (A * B * C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }
    }
}
