namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  //         private double[] _noten = new double[10];
  //         private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)

    // TODO 3: Note ins Array schreiben und _anzahl erhöhen

    // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;

    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik)
  }

  private double Average(double[] noten, int anzahl)
  {
    // TODO: Durchschnitt der ersten "anzahl" Noten
    return 0;
  }

  private double Best(double[] noten, int anzahl)
  {
    // TODO: Höchste Note finden
    return 0;
  }

  private double Worst(double[] noten, int anzahl)
  {
    // TODO: Niedrigste Note finden
    return 0;
  }
}
