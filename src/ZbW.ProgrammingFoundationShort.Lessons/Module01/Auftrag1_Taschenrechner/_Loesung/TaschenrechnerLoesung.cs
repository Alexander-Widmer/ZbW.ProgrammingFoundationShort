namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

/// <summary>
/// Musterlösung: Auftrag 1 – Taschenrechner
/// </summary>
public static class TaschenrechnerLoesung
{
  public static void Start()
  {
    Console.Write("Erste Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Zweite Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl2))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    Console.Write("Operation (+, -, *, /): ");
    string operation = (Console.ReadLine() ?? "").Trim();

    double result;

    if (operation == "+")
    {
      result = zahl1 + zahl2;
    }
    else if (operation == "-")
    {
      result = zahl1 - zahl2;
    }
    else if (operation == "*")
    {
      result = zahl1 * zahl2;
    }
    else if (operation == "/")
    {
      if (zahl2 == 0)
      {
        Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
        return;
      }

      result = zahl1 / zahl2;
    }
    else
    {
      Console.WriteLine($"Unbekannte Operation: '{operation}'");
      return;
    }

    Console.WriteLine($"Ergebnis: {result:F2}");
  }
}
