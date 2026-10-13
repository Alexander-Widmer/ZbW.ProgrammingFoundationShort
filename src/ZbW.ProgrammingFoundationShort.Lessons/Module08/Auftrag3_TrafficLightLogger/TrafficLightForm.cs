namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger;

// ============================================================
// AUFTRAG 3 – Enum-gesteuerte TrafficLight mit statischem Logger
//
// Anforderungen:
//   - Enum TrafficLightColor verwenden
//   - Klasse TrafficLight mit CurrentColor, Change() und ChangeIntervalMs
//   - Timer wechselt alle 2 Sekunden die Farbe
//   - Panel und Label zeigen aktuellen Zustand
//   - AppLogger.Log(...) für Log-Einträge verwenden
//   - ListBox zeigt alle Log-Meldungen
// ============================================================

public sealed class TrafficLightForm : Form
{
  private readonly System.Windows.Forms.Timer TmrTakt;
  private readonly Panel PnlTrafficLight;
  private readonly Label LblState;
  private readonly Button CmdStartStop;
  private readonly Button CmdClear;
  private readonly ListBox LstLog;

  public TrafficLightForm()
  {
    Text = "TrafficLight Logger – Auftrag 3";
    ClientSize = new Size(460, 340);

    PnlTrafficLight = new Panel { Location = new Point(12, 12), Size = new Size(120, 90), BorderStyle = BorderStyle.FixedSingle };
    LblState = new Label { Location = new Point(145, 12), Size = new Size(290, 45), Font = new Font(Font.FontFamily, 14F, FontStyle.Bold) };
    CmdStartStop = new Button { Location = new Point(145, 70), Size = new Size(120, 30), Text = "Start" };
    CmdClear = new Button { Location = new Point(275, 70), Size = new Size(120, 30), Text = "Log leeren" };
    LstLog = new ListBox { Location = new Point(12, 120), Size = new Size(420, 200) };

    TmrTakt = new System.Windows.Forms.Timer();
    TmrTakt.Interval = TrafficLight.ChangeIntervalMs;
    TmrTakt.Tick += Timer_Tick;

    CmdStartStop.Click += CmdStartStop_Click;
    CmdClear.Click += CmdClear_Click;

    Controls.Add(PnlTrafficLight);
    Controls.Add(LblState);
    Controls.Add(CmdStartStop);
    Controls.Add(CmdClear);
    Controls.Add(LstLog);

    UpdateView();
  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    // TODO 1: TrafficLight.Change() aufrufen.
    // TODO 2: AppLogger.Log(...) aufrufen.
    // TODO 3: UpdateView() aufrufen.
  }

  private void CmdStartStop_Click(object sender, EventArgs e)
  {
    // TODO: Timer starten/stoppen und Buttontext aktualisieren.
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    AppLogger.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    LblState.Text = $"Aktuelle Farbe: {TrafficLight.CurrentColor}";
    PnlTrafficLight.BackColor = Color.Gray;
    LstLog.Items.Clear();

    foreach (string message in AppLogger.GetMessages())
    {
      LstLog.Items.Add(message);
    }
  }
}
