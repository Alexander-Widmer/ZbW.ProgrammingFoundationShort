namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

partial class MathUtilsFormLoesung
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
    LblGolden = new Label();
    LblEingabe = new Label(); TxtEingabe = new TextBox();
    GrpFunktion = new GroupBox();
    RadPrim = new RadioButton(); RadFakultaet = new RadioButton(); RadLinspace = new RadioButton();
    CmdBerechnen = new Button(); LblErgebnis = new Label();
    GrpFunktion.SuspendLayout();
    SuspendLayout();

    LblGolden.AutoSize = true; LblGolden.Location = new Point(12, 12); LblGolden.Name = "LblGolden"; LblGolden.Text = "";
    LblEingabe.AutoSize = true; LblEingabe.Location = new Point(12, 45); LblEingabe.Text = "Eingabe n:";
    TxtEingabe.Location = new Point(100, 42); TxtEingabe.Name = "TxtEingabe"; TxtEingabe.Size = new Size(80, 23);

    GrpFunktion.Location = new Point(12, 75); GrpFunktion.Name = "GrpFunktion"; GrpFunktion.Size = new Size(280, 40); GrpFunktion.Text = "Funktion";
    GrpFunktion.Controls.Add(RadPrim); GrpFunktion.Controls.Add(RadFakultaet); GrpFunktion.Controls.Add(RadLinspace);
    RadPrim.AutoSize = true; RadPrim.Checked = true; RadPrim.Location = new Point(8, 15); RadPrim.Name = "RadPrim"; RadPrim.Text = "Primzahl?";
    RadFakultaet.AutoSize = true; RadFakultaet.Location = new Point(100, 15); RadFakultaet.Name = "RadFakultaet"; RadFakultaet.Text = "n!";
    RadLinspace.AutoSize = true; RadLinspace.Location = new Point(160, 15); RadLinspace.Name = "RadLinspace"; RadLinspace.Text = "Linspace";

    CmdBerechnen.Location = new Point(12, 125); CmdBerechnen.Name = "CmdBerechnen"; CmdBerechnen.Size = new Size(120, 28); CmdBerechnen.Text = "Berechnen"; CmdBerechnen.Click += CmdBerechnen_Click;
    LblErgebnis.AutoSize = true; LblErgebnis.Location = new Point(12, 165); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(360, 210);
    Controls.Add(LblGolden); Controls.Add(LblEingabe); Controls.Add(TxtEingabe);
    Controls.Add(GrpFunktion); Controls.Add(CmdBerechnen); Controls.Add(LblErgebnis);
    Name = "MathUtilsFormLoesung"; Text = "MathUtils – Auftrag 2 (Lösung)";
    GrpFunktion.ResumeLayout(false); GrpFunktion.PerformLayout();
    ResumeLayout(false); PerformLayout();
  }

  private Label LblGolden;
  private Label LblEingabe; private TextBox TxtEingabe;
  private GroupBox GrpFunktion;
  private RadioButton RadPrim; private RadioButton RadFakultaet; private RadioButton RadLinspace;
  private Button CmdBerechnen; private Label LblErgebnis;
}
