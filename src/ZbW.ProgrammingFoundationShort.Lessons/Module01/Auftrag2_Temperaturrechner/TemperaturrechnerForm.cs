namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~10 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  // TODO 1: Konstante für den absoluten Nullpunkt definieren
  //         private const double AbsoluteZero = -273.15;

  // Physikalischer Nullpunkt in Grad Celsius.
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    // TODO 2: Wert aus TxtCelsius lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // Eingabe validieren.
    if (!double.TryParse(TxtCelsius.Text, out double celsius))
    {
      MessageBox.Show("Bitte einen gültigen Celsius-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // TODO 3: Prüfen ob Wert < AbsoluteZero
    //         → MessageBox mit Warnung, aber weiter rechnen

    // Physikalischen Grenzwert überprüfen.
    if (celsius < AbsoluteZero)
    {
      MessageBox.Show(
        $"Warnung: {celsius} °C liegt unter dem absoluten Nullpunkt ({AbsoluteZero} °C).",
        "Physikalisch unmöglich",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }

    // TODO 4: Formel anwenden: fahrenheit = celsius * 9.0 / 5.0 + 32

    // Celsius in Fahrenheit umrechnen.
    double fahrenheit = celsius * 9.0 / 5.0 + 32;

    // TODO 5: Ergebnis in TxtFahrenheit anzeigen ($"{fahrenheit:F2}")

    // Ergebnis mit zwei Nachkommastellen ausgeben.
    TxtFahrenheit.Text = $"{fahrenheit:F2}";
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // Eingabe validieren.
    if (!double.TryParse(TxtFahrenheit.Text, out double fahrenheit))
    {
      MessageBox.Show("Bitte einen gültigen Fahrenheit-Wert eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0

    // Fahrenheit in Celsius umrechnen.
    double celsius = (fahrenheit - 32) * 5.0 / 9.0;

    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung

    // Umgerechneten Wert auf physikalischen Grenzwert prüfen.
    if (celsius < AbsoluteZero)
    {
      MessageBox.Show(
        $"Warnung: Ergebnis {celsius:F2} °C liegt unter dem absoluten Nullpunkt.",
        "Physikalisch unmöglich",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")

    // Ergebnis mit zwei Nachkommastellen ausgeben.
    TxtCelsius.Text = $"{celsius:F2}";
  }
}
