﻿using Area.Calculation.Models.Triangle;

namespace Area.Calculation.Figures
{
    public class Triangle
    {
        private string triangleType = string.Empty;

        /// <summary>
        /// Вычисляет площадь
        /// </summary>
        /// <param name="triangleModel">Модель треугольника</param>
        /// <returns>Площадь</returns>
        public double TriangleCalculation(TriangleModel triangleModel)
        {
            triangleType = TypeTriangle(triangleModel);

            if (triangleType == "Rectangular")
                return ((RectangularTriangleModel)triangleModel).CalculateTriangle();
            else
                return ((UniversalTriangleModel)triangleModel).CalculateTriangle();
        }

        /// <summary>
        /// Узнаем какого типа треугольник
        /// </summary>
        /// <param name="triangle"> Модель треугольника</param>
        /// <returns>Тип треугольника</returns>
        private string TypeTriangle(TriangleModel triangle)
        {
            string typeTriangle = string.Empty;

            double A = Math.Pow(triangle.A, 2);
            double B = Math.Pow(triangle.B, 2);
            double C = Math.Pow(triangle.C, 2);

            double AB = A + B;
            double AC = A + C;
            double CB = C + B;

            if (AB == C || AC == B || CB == A)
                triangleType = "Rectangular";
            else
                triangleType = "Another";

            return typeTriangle;
        }
    }
}
