

namespace TallerHerencia2026_1.Backend
{
    public class Trapeze : Triangle
    {
        //Fields
        private double _d;

        //constructors
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(a, b,c, h)
        {
            Name = name;
            D = d;
        }

        //Propierts
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        //Methods

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(D), "one side cannot have length 0");

            }
            return d;
        }

    }
}
