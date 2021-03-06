﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureCalculator.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Tools.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void CalcAreaTest()
        {
            var rect = new Rectangle(3f, 7f);
            Assert.AreEqual(rect.CalcArea(), 21f);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Not valid arguments")]
        public void NotValidArgumentsInConstructor()
        {
            var rect = new Rectangle(0f, 7f);
            rect = new Rectangle(3f, 0f);
            rect = new Rectangle(-3f, 7f);
            rect = new Rectangle(3f, -7f);
        }
    }
}