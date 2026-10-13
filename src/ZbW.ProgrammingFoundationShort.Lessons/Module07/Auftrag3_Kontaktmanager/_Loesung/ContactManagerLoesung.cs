namespace ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager;

/// <summary>Lösung: Kontaktlogik ohne WinForms-Abhängigkeit.</summary>
public class ContactManagerLoesung
{
  private readonly List<PersonKontaktLoesung> _kontakte = new();

  public bool Add(PersonKontaktLoesung kontakt)
  {
    if (_kontakte.Contains(kontakt))
    {
      return false;
    }

    _kontakte.Add(kontakt);
    return true;
  }

  public bool RemoveAt(int index)
  {
    if (index < 0 || index >= _kontakte.Count)
    {
      return false;
    }

    _kontakte.RemoveAt(index);
    return true;
  }

  public List<PersonKontaktLoesung> GetAll()
  {
    return new List<PersonKontaktLoesung>(_kontakte);
  }
}
