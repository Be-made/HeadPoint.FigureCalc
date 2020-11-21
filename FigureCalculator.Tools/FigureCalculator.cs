using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tools
{
    public class FigureCalculator
    {
        /// <summary>
        /// Подсчёт суммы площадей фигур
        /// </summary>
        /// <param name="figures"></param>
        /// <returns></returns>
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
