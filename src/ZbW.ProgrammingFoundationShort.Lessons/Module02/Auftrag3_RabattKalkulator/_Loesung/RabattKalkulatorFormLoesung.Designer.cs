namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator;

partial class RabattKalkulatorFormLoesung
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblBetrag = new Label();
    TxtBetrag = new TextBox();
    GrpKundentyp = new GroupBox();
    RadNormal = new RadioButton();
    RadPremium = new RadioButton();
    RadVip = new RadioButton();
    ChkLehrling = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpKundentyp.SuspendLayout();
    SuspendLayout();

    LblBetrag.AutoSize = true;
    LblBetrag.Location = new Point(12, 20);
    LblBetrag.Text = "Betrag (CHF):";

    TxtBetrag.Location = new Point(130, 17);
    TxtBetrag.Name = "TxtBetrag";
    TxtBetrag.Size = new Size(100, 23);

    GrpKundentyp.Location = new Point(12, 50);
    GrpKundentyp.Name = "GrpKundentyp";
    GrpKundentyp.Size = new Size(220, 95);
    GrpKundentyp.Text = "Kundentyp";
    GrpKundentyp.Controls.Add(RadNormal);
    GrpKundentyp.Controls.Add(RadPremium);
    GrpKundentyp.Controls.Add(RadVip);

    RadNormal.AutoSize = true;
    RadNormal.Checked = true;
    RadNormal.Location = new Point(10, 20);
    RadNormal.Name = "RadNormal";
    RadNormal.Text = "Normal (0%)";

    RadPremium.AutoSize = true;
    RadPremium.Location = new Point(10, 45);
    RadPremium.Name = "RadPremium";
    RadPremium.Text = "Premium (10%)";

    RadVip.AutoSize = true;
    RadVip.Location = new Point(10, 68);
    RadVip.Name = "RadVip";
    RadVip.Text = "VIP (20%)";

    ChkLehrling.AutoSize = true;
    ChkLehrling.Location = new Point(12, 155);
    ChkLehrling.Name = "ChkLehrling";
    ChkLehrling.Text = "Lehrling (+5%)";

    CmdBerechnen.Location = new Point(12, 185);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 225);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(360, 290);
    Controls.Add(LblBetrag);
    Controls.Add(TxtBetrag);
    Controls.Add(GrpKundentyp);
    Controls.Add(ChkLehrling);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Name = "RabattKalkulatorFormLoesung";
    Text = "Rabatt-Kalkulator – Lösung";
    GrpKundentyp.ResumeLayout(false);
    GrpKundentyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblBetrag;
  private TextBox TxtBetrag;
  private GroupBox GrpKundentyp;
  private RadioButton RadNormal;
  private RadioButton RadPremium;
  private RadioButton RadVip;
  private CheckBox ChkLehrling;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
