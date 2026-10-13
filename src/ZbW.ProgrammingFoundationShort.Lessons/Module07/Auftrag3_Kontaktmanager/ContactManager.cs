namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Kontaktlogik ohne WinForms-Abhängigkeit.</summary>
public class ContactManager
{
  private readonly List<PersonKontakt> _kontakte = new();

  public bool Add(PersonKontakt kontakt)
  {
    // TODO 4: Duplikat prüfen (Contains nutzt dein Equals!) → false zurückgeben
    //         sonst hinzufügen und true zurückgeben
    return false;
  }

  public bool RemoveAt(int index)
  {
    // TODO 5: ungültigen Index abfangen (false), sonst entfernen (true)
    return false;
  }

  public List<PersonKontakt> GetAll()
  {
    // TODO 6: Kopie der Liste zurückgeben, damit niemand die interne Liste verändert
    return new List<PersonKontakt>();
  }
}
