namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

/// <summary>
///   Lösung: Auftrag 2 – Noten-Verwaltung
///   Array mit Zähler, Statistikmethoden mit Parametern, sortierte Anzeige.
/// </summary>
public partial class NotenVerwaltungFormLoesung : Form
{
  private readonly double[] _noten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtNote.Text, out double note) || double.IsNaN(note) || note < 1.0 || note > 6.0)
    {
      MessageBox.Show("Bitte eine gültige Note zwischen 1.0 und 6.0 eingeben.",
        "Ungültige Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _noten[_anzahl] = note;
    _anzahl++;
    TxtNote.Clear();

    if (_anzahl == _noten.Length)
    {
      CmdHinzufuegen.Enabled = false; // Array ist voll
    }

    AktualisiereAnzeige();
  }

  private void AktualisiereAnzeige()
  {
    // Nur die belegten Plätze kopieren und sortieren – das Original bleibt unverändert
    double[] sortiert = new double[_anzahl];
    Array.Copy(_noten, sortiert, _anzahl);
    Array.Sort(sortiert);

    string text = "";
    for (int i = 0; i < sortiert.Length; i++)
    {
      if (i > 0)
      {
        text += ", ";
      }

      text += sortiert[i].ToString("F1");
    }

    LblNoten.Text = text;
    LblStats.Text = $"Durchschnitt: {Average(_noten, _anzahl):F2}  |  " +
                    $"Beste: {Best(_noten, _anzahl):F1}  |  Schlechteste: {Worst(_noten, _anzahl):F1}";
  }

  private double Average(double[] noten, int anzahl)
  {
    double summe = 0;
    for (int i = 0; i < anzahl; i++)
    {
      summe += noten[i];
    }

    return summe / anzahl;
  }

  private double Best(double[] noten, int anzahl)
  {
    double best = noten[0];
    for (int i = 1; i < anzahl; i++)
    {
      if (noten[i] > best)
      {
        best = noten[i];
      }
    }

    return best;
  }

  private double Worst(double[] noten, int anzahl)
  {
    double worst = noten[0];
    for (int i = 1; i < anzahl; i++)
    {
      if (noten[i] < worst)
      {
        worst = noten[i];
      }
    }

    return worst;
  }
}
