using TallerHerencia2026_1.Backend;

var circle = new Circle(name: nameof(Circle), r: 5);

var figures = new List<GeometricFigure>
{ circle};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}