namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger;

public static class AppLogger
{
  private static readonly List<string> _messages = new List<string>();

  public static List<string> GetMessages()
  {
    return new List<string>(_messages); // Kopie zurückgeben
  }

  public static void Log(string message)
  {
    // TODO: Zeitstempel und Meldung in _messages speichern.
  }

  public static void Clear()
  {
    _messages.Clear();
  }
}