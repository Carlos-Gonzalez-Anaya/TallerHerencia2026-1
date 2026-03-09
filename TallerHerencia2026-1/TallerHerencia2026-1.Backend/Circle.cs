
namespace TallerHerencia2026_1.Backend
{
    public class Circle : GeometricFigure
    {
        //Fields
        private double _r;

        //Constructors

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        //propierties
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        //Methods
        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private double ValidateR(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException(nameof(R), "the radius of a circle cannot be 0");
            }
            return r;

        }
    }
}
