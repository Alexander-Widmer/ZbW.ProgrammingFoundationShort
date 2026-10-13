namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

/// <summary>
/// Musterlösung: Auftrag 3 – Datentyp-Quiz
/// </summary>
public static class DatentypQuizLoesung
{
  public static void Start()
  {
    var stopwatch = System.Diagnostics.Stopwatch.StartNew();
    int punkte = 0;

    // ── Frage 1 (Text) ───────────────────────────────────────
    Console.Write("Frage 1: Welcher Datentyp speichert true/false? ");
    string antwort1 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort1 == "bool")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: bool");
    }

    // ── Frage 2 (Text) ───────────────────────────────────────
    Console.Write("Frage 2: Welcher Datentyp eignet sich für Geldbeträge? ");
    string antwort2 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort2 == "decimal")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: decimal");
    }

    // ── Frage 3 (Zahl → int.TryParse) ────────────────────────
    Console.Write("Frage 3: Was ergibt 7 / 2, wenn beide Zahlen int sind? ");

    if (int.TryParse(Console.ReadLine() ?? "", out int antwort3) && antwort3 == 3)
    {
      Console.WriteLine("  Richtig! (Ganzzahldivision)");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: 3");
    }

    // ── Frage 4 (Zahl → int.TryParse) ────────────────────────
    Console.Write("Frage 4: Was ergibt 10 % 3? ");

    if (int.TryParse(Console.ReadLine() ?? "", out int antwort4) && antwort4 == 1)
    {
      Console.WriteLine("  Richtig! (Rest der Division)");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: 1");
    }

    // ── Frage 5 (Text) ───────────────────────────────────────
    Console.Write("Frage 5: Welcher Datentyp speichert genau ein Zeichen? ");
    string antwort5 = (Console.ReadLine() ?? "").Trim().ToLower();

    if (antwort5 == "char")
    {
      Console.WriteLine("  Richtig!");
      punkte++;
    }
    else
    {
      Console.WriteLine("  Falsch. Richtige Antwort: char");
    }

    stopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine($"Resultat: {punkte}/5");
    Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }
}
