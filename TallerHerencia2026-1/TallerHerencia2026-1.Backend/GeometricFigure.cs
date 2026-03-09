namespace TallerHerencia2026_1.Backend
{
    public abstract class GeometricFigure
    {

        //propierties
        public string Name 
        { 
            get;
            set; 
        }

        //Methods

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"Area: {GetArea():F2}\n" +
                   $"Perimeter: {GetPerimeter():F2}\n";
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
