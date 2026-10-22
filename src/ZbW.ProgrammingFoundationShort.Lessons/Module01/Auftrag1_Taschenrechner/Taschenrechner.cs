namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~10 Min.)
//
// Erstelle eine Konsolen-App, die zwei Zahlen und eine Operation
// einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Tipp: Starte Program.cs mit Application.Run(null) und rufe
//        Taschenrechner.Start() auf — oder lege eine eigene
//        Konsolen-App an und rufe Start() direkt auf.
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Berechnet das Ergebnis zweier Zahlen für eine gegebene Operation.
  /// </summary>
  ///<param name="firstNumber">Linker Operand.</param>
  ///<param name="secondNumber">Rechter Operand.</param>
  /// <param name="operation">Operator als Zeichen: +, -, *, /</param>
  /// <returns>Das berechnete Ergebnis.</returns>
  /// <exception cref="DivideByZeroException">Wird geworfen bei Division durch 0.</exception>
  /// <exception cref="ArgumentException">Wird geworfen bei ungültigem Operator.</exception>
  public static double Berechnen(
  double firstNumber,
  double secondNumber,
  string operation)
  {
    // TODO: Implementiere die Berechnung
    //       Verwende switch (operation) mit den Fällen +, -, *, /
    //       Wirf DivideByZeroException wenn zahl2 == 0 und operation == "/"
    //       Wirf ArgumentException bei unbekanntem Operator
    switch (operation)
    {
      case "+": return firstNumber + secondNumber;
      case "-": return firstNumber - secondNumber;
      case "*": return firstNumber * secondNumber;
      case "/":
        if (secondNumber == 0)
        {
          throw new DivideByZeroException("Division durch 0 ist nicht erlaubt.");
        }
        return firstNumber / secondNumber;

      default:
        throw new ArgumentException("Unbekannter Operator.");
    }
  }

  /// <summary>
  ///   Startet den interaktiven Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Erste Zahl einlesen
    //         Console.Write("Erste Zahl: ");
    //         string input1 = Console.ReadLine();
    //         double zahl1 = ...

    //Kommentar Alex: Namenkonvention in den Beispielen nicht korrekt, daher angepasst.

    Console.Write("Erste Zahl: ");
    string input1 = Console.ReadLine() ?? "";

    if (double.TryParse(input1, out double firstNumber))
    {
      // Zahl erfolgreich konvertiert
    }
    else
    {
      Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben.");
      return;
    }

    // TODO 2: Zweite Zahl einlesen (gleiche Technik wie TODO 1)

    Console.Write("Zweite Zahl: ");
    string input2 = Console.ReadLine() ?? "";

    if (double.TryParse(input2, out double secondNumber))
    {
      // Zahl erfolgreich konvertiert
    }
    else
    {
      Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben.");
      return;
    }



    // TODO 3: Operation einlesen (+, -, *, /)
    Console.Write("Operation (+,-,*,/): ");
    string operation = (Console.ReadLine() ?? "").Trim();

    // Trim() entfernt führende und nachfolgende Leerzeichen.

    // TODO 3.1: Operator validieren
    // Bei && endet die Auswertung, sobald ein Vergleich false ergibt.
    if (operation != "+" &&
        operation != "-" &&
        operation != "*" &&
        operation != "/")
    {
      Console.WriteLine("Ungültiger Operator. Erlaubt sind +, -, * und /.");
      return;
    }

    // TODO 4: Berechnung durchführen (switch oder if/else)
    //         Achtung: Division durch 0 abfangen!

    // Ergebnisvariable ausserhalb von try deklarieren.
    double result;

    try
    {
      // Berechnung ausführen und Ergebnis speichern.
      result = Berechnen(firstNumber, secondNumber, operation);
    }
    catch (DivideByZeroException exception)
    {
      // Division durch null abfangen und Fehlermeldung ausgeben.
      Console.WriteLine($"Fehler: {exception.Message}");
      return; // Methode bei Fehler beenden.
    }

    // TODO 5: Ergebnis ausgeben: $"{result:F2}"
    // Berechnetes Ergebnis mit String-Interpolation ausgeben.
    // F2 formatiert den Zahlenwert auf zwei Nachkommastellen.
    Console.WriteLine($"Ergebnis: {result:F2}");
  }
}
