namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_TodosUmsetzen;

public static class TodosUmsetzen
{
  public static string EvaluatePoints(int points)
  {
    // TODO: Wenn points kleiner als 0 oder grösser als 100 ist, "Ungültig" zurückgeben.
    // TODO: Wenn points mindestens 80 ist, "Sehr gut" zurückgeben.
    // TODO: Wenn points mindestens 60 ist, "Bestanden" zurückgeben.
    // TODO: Sonst "Nicht bestanden" zurückgeben.
    return "TODO";
  }

  public static string RunDemo()
  {
    int[] testValues = { -5, 0, 50, 59, 60, 79, 80, 85, 100, 101, 120 }; // inkl. Grenzwerte
    List<string> lines = new List<string>();

    foreach (int points in testValues)
    {
      lines.Add($"{points}: {EvaluatePoints(points)}");
    }

    return string.Join(Environment.NewLine, lines);
  }
}