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
    public class RightTriangleTests
    {
        [TestMethod()]
        public void CalcAreaTest()
        {
            var rightTriangle = new RightTriangle(3f, 7f);
            Assert.AreEqual(rightTriangle.CalcArea(), 10.5f);
        }
    }
}