
namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz;

// ============================================================
// AUFTRAG 3 – Datentyp-Quiz (⭐⭐⭐ Erweitert | ~10 Min.)
//
// Erstelle ein Quiz mit 5 Fragen zu C#-Datentypen.
//
// Anforderungen:
//   - Fragen per Console.Write ausgeben
//   - Antwort mit Console.ReadLine() einlesen
//   - Am Ende: $"Resultat: {punkte}/5" ausgeben
//   - Mindestens 1 Frage erwartet eine Zahl (int.TryParse)
//   - Gross-/Kleinschreibung ignorieren: .ToLower()
//   - Bonus: Zeit pro Frage mit Stopwatch messen
// ============================================================

public static class DatentypQuiz
{
  /// <summary>
  ///   Prüft ob eine Antwort (case-insensitiv) korrekt ist.
  /// </summary>
  public static bool IstKorrekt(string gegebeneAntwort, string richtigeAntwort)
  {
    // TODO: Vergleiche gegebeneAntwort.Trim().ToLower() mit richtigeAntwort.ToLower()

    // Beide Zeichenketten normalisieren und vergleichen.
    return gegebeneAntwort.Trim().ToLower() == richtigeAntwort.ToLower();
  }

  // TODO 1: Fragen und Antworten definieren
  //         Tipp: Verwende zwei parallele Arrays oder ein Dictionary
  //
  // Beispiel-Fragen:
  //   "Wie viele Bits hat ein int?"          → Antwort: "32"
  //   "Welcher Typ speichert true/false?"    → Antwort: "bool"
  //   "Was ist der Standardwert von int?"    → Antwort: "0"
  //   "Welcher Typ für genaue Geldbeträge?"  → Antwort: "decimal"
  //   "Max-Wert von byte?"                   → Antwort: "255"

  private static readonly string[] _questions =
  {
    "Wie viele Bits hat ein int?",
    "Welcher Typ speichert true/false?",
    "Was ist der Standardwert von int?",
    "Welcher Typ eignet sich für genaue Geldbeträge?",
    "Was ist der Maximalwert von byte?"
  };

  private static readonly string[] _answers =
  {
    "32",
    "bool",
    "0",
    "decimal",
    "255"
  };

  /// <summary>
  ///   Startet das Quiz auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 2: Stopwatch starten (Bonus)
    //         var stopwatch = new System.Diagnostics.Stopwatch();
    //         stopwatch.Start();

    var stopwatch = System.Diagnostics.Stopwatch.StartNew();

    // int punkte = 0; // TODO: aktivieren, wenn die Schleife implementiert wird.
    int points = 0;

    // TODO 3: Schleife über alle Fragen
    //         for (int i = 0; i < fragen.Length; i++)
    //         {
    //             Console.Write($"Frage {i + 1}: {fragen[i]} ");
    //             string antwort = Console.ReadLine() ?? "";
    //
    //             // Prüfen ob Antwort korrekt ist (ToLower-Vergleich)
    //             // Bei Zahlen-Fragen: int.TryParse verwenden
    //         }

    for (int i = 0; i < _questions.Length; i++)
    {
      // Aktuelle Frage anzeigen und Benutzereingabe einlesen.
      Console.Write($"Frage {i + 1}: {_questions[i]} ");
      string userAnswer = Console.ReadLine() ?? "";

      bool isCorrect;

      // Prüfen, ob eine numerische Antwort erwartet wird.
      if (int.TryParse(_answers[i], out int expectedNumber))
      {
        // Numerische Benutzereingabe validieren und vergleichen.
        isCorrect = int.TryParse(userAnswer, out int enteredNumber)
                    && enteredNumber == expectedNumber;
      }
      else
      {
        // Textantwort ohne Berücksichtigung der Grossschreibung prüfen.
        isCorrect = IstKorrekt(userAnswer, _answers[i]);
      }

      if (isCorrect)
      {
        Console.WriteLine("Richtig!");
        points++;
      }
      else
      {
        Console.WriteLine($"Falsch. Richtige Antwort: {_answers[i]}");
      }
    }

    // TODO 4: Ergebnis ausgeben
    //         Console.WriteLine($"Resultat: {punkte}/5");

    Console.WriteLine($"Resultat: {points}/5");

    // TODO 5 (Bonus): Stopwatch stoppen und Zeit ausgeben
    //         stopwatch.Stop();
    //         Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");

    stopwatch.Stop();
    Console.WriteLine($"Zeit: {stopwatch.Elapsed.TotalSeconds:F1} Sekunden");
  }
}
