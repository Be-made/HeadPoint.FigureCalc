using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureCalculator.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tools.Tests
{
    [TestClass()]
    public class FigureCalculatorTests
    {
        FigureCalculator figureCalculator = new FigureCalculator();

        [TestMethod()]
        public void CalcAreaSumTest()
        {
            var rect = new Rectangle(3f, 7f);
            var rightTriangle = new RightTriangle(3f, 7f);

            var calculatedAreaSum = figureCalculator.CalcAreaSum(new List<IFigure>
            {
                rect,
                rightTriangle
            });

            Assert.AreEqual(calculatedAreaSum, 31.5f);
        }
    }
}