namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy;

// ============================================================
// AUFTRAG 3 – Media Hierarchy mit Polymorphismus (⭐⭐ Mittel | ~30 Min.)
//
// Anforderungen:
//   - abstract class MediaItem: Property Title, protected Konstruktor MediaItem(string title)
//     abstract void PrintInfo()
//   - Book(title, author), Magazine(title, issueNumber), DVD(title, lengthMinutes)
//     erben von MediaItem, rufen base(title) auf und überschreiben PrintInfo()
//   - PrintAll(List<MediaItem> items) ruft PrintInfo() polymorph auf
//   - Start(): je 2 Instanzen jeder Klasse, PrintAll aufrufen
// ============================================================

public abstract class MediaItem
{
  // TODO 1: Property Title und protected Konstruktor MediaItem(string title)

  // TODO 2: abstract void PrintInfo()
}

// TODO 3: Klassen Book, Magazine und DVD

public static class MediaDemo
{
  public static void Start()
  {
    // TODO 4: List<MediaItem> mit je 2 Book, Magazine und DVD erstellen
    // TODO 5: PrintAll(media) aufrufen
  }

  public static void PrintAll(List<MediaItem> items)
  {
    // TODO 6: foreach über alle Elemente und PrintInfo() aufrufen
  }
}
