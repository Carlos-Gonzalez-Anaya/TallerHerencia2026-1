namespace TallerHerencia2026_1.Backend
{
    public class Triangle : Rectangle
    {
        // Fields
        private double _c;
        private double _h;

        // Constructor
        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            Name = name;
            C = c;
            H = h;
        }

        // Properties
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        // Methods
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        private double ValidateC(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(C),
                    "One side cannot have length 0 or negative");
            }

            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(H),
                    "Height cannot be 0 or negative");
            }

            return h;
        }
    }
}