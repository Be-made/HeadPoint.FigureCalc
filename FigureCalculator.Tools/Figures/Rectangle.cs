using System;

namespace FigureCalculator.Tools
{
    public class Rectangle : IFigure
    {
        private readonly float sideA;

        private readonly float sideB;

        public Rectangle(float sideA, float sideB)
        {
            if (sideA <= 0f || sideB <= 0f)
                throw new ArgumentException("Not valid arguments");

            this.sideA = sideA;
            this.sideB = sideB;
        }

        public float CalcArea()
        {
            return sideA * sideB;
        }
    }
}
