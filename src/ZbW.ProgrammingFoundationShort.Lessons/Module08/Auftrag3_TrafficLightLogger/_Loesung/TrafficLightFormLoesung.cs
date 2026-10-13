namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger._Loesung;

public sealed class TrafficLightFormLoesung : Form
{
  private readonly System.Windows.Forms.Timer TmrTakt;
  private readonly Panel PnlTrafficLight;
  private readonly Label LblState;
  private readonly Button CmdStartStop;
  private readonly Button CmdClear;
  private readonly ListBox LstLog;

  public TrafficLightFormLoesung()
  {
    Text = "TrafficLight Logger – Lösung";
    ClientSize = new Size(460, 340);

    PnlTrafficLight = new Panel { Location = new Point(12, 12), Size = new Size(120, 90), BorderStyle = BorderStyle.FixedSingle };
    LblState = new Label { Location = new Point(145, 12), Size = new Size(290, 45), Font = new Font(Font.FontFamily, 14F, FontStyle.Bold) };
    CmdStartStop = new Button { Location = new Point(145, 70), Size = new Size(120, 30), Text = "Start" };
    CmdClear = new Button { Location = new Point(275, 70), Size = new Size(120, 30), Text = "Log leeren" };
    LstLog = new ListBox { Location = new Point(12, 120), Size = new Size(420, 200) };

    TmrTakt = new System.Windows.Forms.Timer();
    TmrTakt.Interval = TrafficLightLoesung.ChangeIntervalMs;
    TmrTakt.Tick += Timer_Tick;

    CmdStartStop.Click += CmdStartStop_Click;
    CmdClear.Click += CmdClear_Click;

    Controls.Add(PnlTrafficLight);
    Controls.Add(LblState);
    Controls.Add(CmdStartStop);
    Controls.Add(CmdClear);
    Controls.Add(LstLog);

    AppLoggerLoesung.Log("Ampel initialisiert.");
    UpdateView();
  }

  private void Timer_Tick(object sender, EventArgs e)
  {
    TrafficLightLoesung.Change();
    AppLoggerLoesung.Log($"Wechsel zu {TrafficLightLoesung.CurrentColor} um {DateTime.Now:HH:mm:ss}");
    UpdateView();
  }

  private void CmdStartStop_Click(object sender, EventArgs e)
  {
    TmrTakt.Enabled = !TmrTakt.Enabled;
    CmdStartStop.Text = TmrTakt.Enabled ? "Stop" : "Start";
  }

  private void CmdClear_Click(object sender, EventArgs e)
  {
    AppLoggerLoesung.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    LblState.Text = TrafficLightLoesung.CurrentColor switch
    {
      TrafficLightColor.Red => "Rot - stopp",
      TrafficLightColor.Yellow => "Gelb - bereit",
      _ => "Grün - fahren"
    };

    PnlTrafficLight.BackColor = TrafficLightLoesung.CurrentColor switch
    {
      TrafficLightColor.Red => Color.Red,
      TrafficLightColor.Yellow => Color.Gold,
      _ => Color.Green
    };

    LstLog.Items.Clear();

    foreach (string message in AppLoggerLoesung.GetMessages())
    {
      LstLog.Items.Add(message);
    }
  }
}

// Das enum TrafficLightColor wird aus TrafficLightState.cs wiederverwendet.
public static class TrafficLightLoesung
{
  public const int ChangeIntervalMs = 2000;

  public static TrafficLightColor CurrentColor { get; private set; } = TrafficLightColor.Red;

  public static void Change()
  {
    CurrentColor = CurrentColor switch
    {
      TrafficLightColor.Red => TrafficLightColor.Green,
      TrafficLightColor.Green => TrafficLightColor.Yellow,
      _ => TrafficLightColor.Red
    };
  }
}
