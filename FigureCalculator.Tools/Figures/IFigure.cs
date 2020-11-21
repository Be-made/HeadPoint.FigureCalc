using System.Threading;

namespace FigureCalculator.Tools
{
    public interface IFigure
    {
        /// <summary>
        /// Метод подсчёта площади фигуры
        /// </summary>
        /// <returns></returns>
        float CalcArea();
    }
}
