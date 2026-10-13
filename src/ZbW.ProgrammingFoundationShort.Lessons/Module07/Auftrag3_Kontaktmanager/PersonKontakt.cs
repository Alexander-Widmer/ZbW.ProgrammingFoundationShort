namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Datenklasse für einen Kontakt.</summary>
public class PersonKontakt
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string? Email { get; set; } // darf null sein

  // TODO 1: Equals(object? obj) überschreiben:
  //         zwei Kontakte sind gleich, wenn FirstName und LastName gleich sind

  // TODO 2: GetHashCode() passend zu Equals überschreiben (HashCode.Combine)

  // TODO 3: ToString() überschreiben: "Vorname Nachname – E-Mail"
  //         fehlt die E-Mail (null), "(keine E-Mail)" anzeigen (Operator ??)
}
