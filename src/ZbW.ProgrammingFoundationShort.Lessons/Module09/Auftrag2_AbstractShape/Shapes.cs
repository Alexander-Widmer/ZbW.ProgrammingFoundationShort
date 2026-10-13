namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape;

// ============================================================
// AUFTRAG 2 – Abstract Shape (⭐⭐ Mittel | ~30 Min.)
//
// Anforderungen:
//   - abstract class Shape: Property Color
//     protected Konstruktor Shape(string color) – nur Subklassen dürfen ihn aufrufen
//     abstract double Area(), abstract double Perimeter()
//     virtual string Describe() → "Circle, Rot: Fläche 78.54, Umfang 31.42" (GetType().Name)
//   - Circle(radius, color), Rectangle(width, height, color),
//     Triangle(a, b, c, color) – Fläche mit der Heron-Formel
//     jeder Konstruktor ruft base(color) auf
//   - Start(): List<Shape> mit je 2 Formen, alle beschreiben, Gesamtfläche ausgeben
// ============================================================

public abstract class Shape
{
  // TODO 1: Property Color und protected Konstruktor Shape(string color)

  // TODO 2: abstract double Area() und abstract double Perimeter()

  // TODO 3: virtual string Describe()
}

// TODO 4: Klassen Circle, Rectangle und Triangle (: Shape)

public static class ShapeDemo
{
  public static void Start()
  {
    // TODO 5: List<Shape> mit je 2 Kreisen, Rechtecken und Dreiecken
    // TODO 6: foreach: Describe() ausgeben und Fläche aufsummieren
    // TODO 7: Gesamtfläche ausgeben
  }
}
