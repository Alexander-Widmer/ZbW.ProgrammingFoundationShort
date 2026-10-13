namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

/// <summary>
///   Lösung: Auftrag 3 – Rabatt-Kalkulator
///   Rabattberechnung mit RadioButtons, CheckBox und if/else.
/// </summary>
public partial class RabattKalkulatorFormLoesung : Form
{
  public RabattKalkulatorFormLoesung()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Betrag validieren
    // decimal für Geldbeträge (Block 01); 0 CHF ist kein sinnvoller Einkauf
    if (!decimal.TryParse(TxtBetrag.Text, out decimal betrag) || betrag <= 0)
    {
      MessageBox.Show("Bitte einen gültigen positiven Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Rabatt aus RadioButton
    int rabatt = 0;
    if (RadPremium.Checked)
    {
      rabatt = 10;
    }
    else if (RadVip.Checked)
    {
      rabatt = 20;
    }

    // Lehrlings-Bonus
    if (ChkLehrling.Checked)
    {
      rabatt += 5;
    }

    // Rabatt in CHF und Endbetrag berechnen
    decimal rabattBetrag = betrag * rabatt / 100m;
    decimal endbetrag = betrag - rabattBetrag;

    // Ergebnis anzeigen: Originalbetrag, Rabatt in CHF, Endbetrag
    LblErgebnis.Text = $"Originalbetrag: {betrag:F2} CHF\r\n" +
                       $"Rabatt: {rabattBetrag:F2} CHF ({rabatt}%)\r\n" +
                       $"Endbetrag: {endbetrag:F2} CHF";
  }
}
