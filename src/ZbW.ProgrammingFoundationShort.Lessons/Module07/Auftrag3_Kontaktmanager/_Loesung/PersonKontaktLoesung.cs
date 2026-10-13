namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Lösung: Datenklasse für einen Kontakt mit null-sicherer Ausgabe und Equals.</summary>
public class PersonKontaktLoesung
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string? Email { get; set; } // nullable

  public override bool Equals(object? obj)
  {
    if (obj is PersonKontaktLoesung other)
    {
      return FirstName == other.FirstName && LastName == other.LastName;
    }

    return false;
  }

  public override int GetHashCode() => HashCode.Combine(FirstName, LastName);

  public override string ToString()
  {
    // ?. und ?? Operatoren
    return $"{FirstName} {LastName} – {Email ?? "(keine E-Mail)"}";
  }
}

