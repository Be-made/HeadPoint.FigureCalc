using FigureCalculator.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadPoint.FigureCalc
{
    /* 
     * Написать калькулятор для подсчета суммы площадей фигур. 
     * На вход принимает список фигур ( обязательные фигуры: прямоугольный треугольник и фигура на выбор).
     * Учесть что в будущем метод может быть расширен другими фигурами. 
     * Метод должен находиться в библиотеке, которая будет использована сторонним клиентом. 
     * Не забыть про тесты. 
     * Решение выложить в публичный репозиторий. 
     */

    class Program
    {
        static void Main(string[] args)
        {
            var figureCalculator = new FigureCalculator.Tools.FigureCalculator();

            var calculatedAreaSum = figureCalculator.CalcAreaSum(new List<IFigure>
            {
                new Rectangle(3f, 7f),
                new RightTriangle(3f, 7f)
            });

            Console.WriteLine("Sum figures area: "+ calculatedAreaSum);
            Console.ReadKey();
        }
    }
}
