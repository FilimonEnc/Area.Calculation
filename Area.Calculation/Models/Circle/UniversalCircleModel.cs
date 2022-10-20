using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Calculation.Models.Circle
{
    internal class UniversalCircleModel : CircleModel
    {
        public override double CalculateCircle()
        {
            double Pi = Math.PI;
            double R = Math.Pow(r, 2);

            S = Pi * R;
            
            return S;
        }
    }
}
