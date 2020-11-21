using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tools
{
    public class FigureCalculator
    {
        public float CalcAreaSum(IEnumerable<IFigure> figures)
        {
            float areaSum = 0;

            foreach (var figure in figures)
            {
                areaSum += figure.CalcArea();
            }

            return areaSum;
        }
    }
}
