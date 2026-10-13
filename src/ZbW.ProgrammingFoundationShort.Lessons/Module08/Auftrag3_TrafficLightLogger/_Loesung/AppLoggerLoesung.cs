namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger._Loesung;

public static class AppLoggerLoesung
{
  private static readonly List<string> _messages = new List<string>();

  public static List<string> GetMessages()
  {
    return new List<string>(_messages); // Kopie zurückgeben
  }

  public static void Log(string message)
  {
    _messages.Add($"{DateTime.Now:HH:mm:ss} - {message}");
  }

  public static void Clear()
  {
    _messages.Clear();
  }
}