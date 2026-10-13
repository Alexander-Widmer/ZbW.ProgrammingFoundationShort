namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

// ============================================================
// AUFTRAG 2 – MathUtils (⭐⭐ Mittel | ~30 Min.)
//
// Nutzt die statische MathUtils-Klasse.
//
// Anforderungen:
//   - MathUtils.cs: IsPrime, Factorial, GenerateLinspace, GoldenRatio implementieren
//   - CmdBerechnen → Eingabe lesen, je nach RadioButton Methode aufrufen
//   - Ergebnis in LblErgebnis anzeigen; ungültige Eingaben abfangen
//   - Lösung: _Loesung/MathUtilsLoesung.cs + MathUtilsFormLoesung.cs
// ============================================================

public partial class MathUtilsForm : Form
{
  public MathUtilsForm()
  {
    InitializeComponent();
    LblGolden.Text = $"Goldener Schnitt: {MathUtils.GoldenRatio:F6}";
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Eingabe lesen (int)

    // TODO 2: Je nach RadioButton:
    //         RadPrim: MathUtils.IsPrime(n)
    //         RadFakultaet: MathUtils.Factorial(n)
    //         RadLinspace: MathUtils.GenerateLinspace(0, n, 5)

    // TODO 3: Ergebnis in LblErgebnis anzeigen
  }
}
