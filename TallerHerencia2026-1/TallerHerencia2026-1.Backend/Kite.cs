

namespace TallerHerencia2026_1.Backend
{
    public class Kite:Rhombus
    {
        // Fields
        private double _b;

        // constructors
        public Kite(string name, double a, double b, double d1, double d2):base(name,a,d1,d2)
        {
            Name = name;
            B = b;
        }

        //Propieties
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        //Methods

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimeter()
        {
            return 2*(A+B);
        }

        private double ValidateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(B), "one side cannot have length 0");

            }
            return b;
        }
    }
}
