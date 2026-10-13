namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben;

/// <summary>
///   Lösung: == vs .Equals() Demo und Contains.
/// </summary>
public static class ProductEqualsDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Equals-Demo ===\n");

    var p1 = new ProductEqualsLoesung { ArticleNumber = "A001", Name = "Schraube M8", Price = 0.50m };
    var p2 = new ProductEqualsLoesung { ArticleNumber = "A001", Name = "Schraube M8 (Kopie)", Price = 0.55m };
    var p3 = new ProductEqualsLoesung { ArticleNumber = "B002", Name = "Mutter M8", Price = 0.30m };

    Console.WriteLine($"p1: {p1}");
    Console.WriteLine($"p2: {p2}");

    // == vergleicht Referenzen
    Console.WriteLine($"\np1 == p2: {p1 == p2}");       // false
    Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // true (gleiche Artikelnummer)
    Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}"); // false

    // Contains nutzt das überschriebene Equals
    List<ProductEqualsLoesung> lager = new List<ProductEqualsLoesung> { p1, p3 };
    Console.WriteLine($"\nLager enthält Artikel wie p2 (A001)? {lager.Contains(p2)}"); // true
  }
}
