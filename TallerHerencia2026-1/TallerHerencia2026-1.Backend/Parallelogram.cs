namespace TallerHerencia2026_1.Backend
{
    public class Parallelogram : Rectangle
    {
        // Fields
        private double _h;

        // Constructor
        public Parallelogram(string name, double a, double b, double h):base(name, a, b)
        {
            Name = name;
            H = h;
        }

        // Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        // Methods
        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimeter()
        {
            return base.GetPerimeter();
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
