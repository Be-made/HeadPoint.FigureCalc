namespace FigureCalculator.Tools
{
    public class RightTriangle : IFigure
    {
        private readonly float legA;

        private readonly float legB;

        public RightTriangle(float legA, float legB)
        {
            this.legA = legA;
            this.legB = legB;
        }

        public float CalcArea()
        {
            return 0.5f * legA * legB;
        }
    }
}
