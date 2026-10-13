namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

/// <summary>Lösung: Auftrag 2 – Form ruft die statischen Methoden über den Klassennamen auf.</summary>
public partial class MathUtilsFormLoesung : Form
{
  public MathUtilsFormLoesung()
  {
    InitializeComponent();
    LblGolden.Text = $"Goldener Schnitt: {MathUtilsLoesung.GoldenRatio:F6}";
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtEingabe.Text, out int n))
    {
      LblErgebnis.Text = "Bitte eine ganze Zahl eingeben.";
      return;
    }

    try
    {
      if (RadPrim.Checked)
      {
        string antwort = MathUtilsLoesung.IsPrime(n) ? "ist" : "ist keine";
        LblErgebnis.Text = $"{n} {antwort} Primzahl.";
      }
      else if (RadFakultaet.Checked)
      {
        LblErgebnis.Text = $"{n}! = {MathUtilsLoesung.Factorial(n)}";
      }
      else
      {
        double[] werte = MathUtilsLoesung.GenerateLinspace(0, n, 5);
        LblErgebnis.Text = "Linspace: " + string.Join(" | ", werte);
      }
    }
    catch (ArgumentException ex)
    {
      LblErgebnis.Text = ex.Message;
    }
  }
}
