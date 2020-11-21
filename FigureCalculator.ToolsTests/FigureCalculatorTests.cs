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
            Assert.Fail();
        }
    }
}