namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

/// <summary>
///   Lösung: Auftrag 2 – WochentageApp
///   switch expression und ternärer Operator.
/// </summary>
public partial class WochentageAppFormLoesung : Form
{
  public WochentageAppFormLoesung()
  {
    InitializeComponent();

    // ComboBox befüllen
    CmbWochentag.Items.AddRange(new object[]
    {
      "Montag", "Dienstag", "Mittwoch", "Donnerstag",
      "Freitag", "Samstag", "Sonntag"
    });
    CmbWochentag.SelectedIndex = 0;
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    string tagName = CmbWochentag.Text;

    // switch expression: Wochenende oder Werktag?
    bool istWerktag = tagName switch
    {
      "Samstag" or "Sonntag" => false,
      _ => true
    };

    // Ternärer Operator für den Ausgabetext
    string typ = istWerktag ? "Werktag" : "Wochenende";
    LblErgebnis.Text = $"{tagName} ist ein {typ}.";
  }
}
