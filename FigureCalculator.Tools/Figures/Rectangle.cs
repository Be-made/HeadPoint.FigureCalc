namespace FigureCalculator.Tools
{
    public class Rectangle : IFigure
    {
        private readonly float sideA;

        private readonly float sideB;

        public Rectangle(float sideA, float sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public float CalcArea()
        {
            return sideA * sideB;
        }
    }
}
