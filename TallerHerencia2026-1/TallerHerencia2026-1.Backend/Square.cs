namespace TallerHerencia2026_1.Backend
{
    public class Square : GeometricFigure
    {
        // Fields
        private double _a;

        // Constructor
        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        // Properties
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        // Methods
        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private double ValidateA(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException(
                    "One side cannot have length 0 or negative",
                    nameof(A));
            }

            return a;
        }
    }
}