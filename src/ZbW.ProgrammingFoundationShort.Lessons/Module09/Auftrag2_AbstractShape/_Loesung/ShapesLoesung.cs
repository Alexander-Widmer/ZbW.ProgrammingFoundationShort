namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape._Loesung;

public abstract class Shape
{
  protected Shape(string color)
  {
    Color = color;
  }

  public string Color { get; }

  public abstract double Area();

  public abstract double Perimeter();

  public virtual string Describe()
  {
    return $"{GetType().Name}, {Color}: Fläche {Area():F2}, Umfang {Perimeter():F2}";
  }
}

public class Circle : Shape
{
  public Circle(double radius, string color) : base(color)
  {
    Radius = radius;
  }

  public double Radius { get; }

  public override double Area()
  {
    return Math.PI * Radius * Radius;
  }

  public override double Perimeter()
  {
    return 2 * Math.PI * Radius;
  }
}

public class Rectangle : Shape
{
  public Rectangle(double width, double height, string color) : base(color)
  {
    Width = width;
    Height = height;
  }

  public double Width { get; }
  public double Height { get; }

  public override double Area()
  {
    return Width * Height;
  }

  public override double Perimeter()
  {
    return 2 * (Width + Height);
  }
}

public class Triangle : Shape
{
  public Triangle(double a, double b, double c, string color) : base(color)
  {
    A = a;
    B = b;
    C = c;
  }

  public double A { get; }
  public double B { get; }
  public double C { get; }

  public override double Area()
  {
    double s = Perimeter() / 2;
    return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
  }

  public override double Perimeter()
  {
    return A + B + C;
  }
}

public static class ShapeDemoLoesung
{
  public static void Start()
  {
    List<Shape> shapes = new List<Shape>
    {
      new Circle(5, "Rot"),
      new Circle(2, "Blau"),
      new Rectangle(4, 3, "Grün"),
      new Rectangle(8, 2, "Gelb"),
      new Triangle(3, 4, 5, "Orange"),
      new Triangle(5, 5, 6, "Violett")
    };

    double totalArea = 0;
    foreach (Shape shape in shapes)
    {
      Console.WriteLine(shape.Describe());
      totalArea += shape.Area();
    }

    Console.WriteLine($"Gesamtfläche: {totalArea:F2}");
  }
}
