namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy._Loesung;

public abstract class MediaItem
{
  protected MediaItem(string title)
  {
    Title = title;
  }

  public string Title { get; }

  public abstract void PrintInfo();
}

public class Book : MediaItem
{
  public Book(string title, string author) : base(title)
  {
    Author = author;
  }

  public string Author { get; }

  public override void PrintInfo()
  {
    Console.WriteLine($"Buch: {Title} von {Author}");
  }
}

public class Magazine : MediaItem
{
  public Magazine(string title, int issueNumber) : base(title)
  {
    IssueNumber = issueNumber;
  }

  public int IssueNumber { get; }

  public override void PrintInfo()
  {
    Console.WriteLine($"Magazin: {Title}, Ausgabe {IssueNumber}");
  }
}

public class DVD : MediaItem
{
  public DVD(string title, int lengthMinutes) : base(title)
  {
    LengthMinutes = lengthMinutes;
  }

  public int LengthMinutes { get; }

  public override void PrintInfo()
  {
    Console.WriteLine($"DVD: {Title}, {LengthMinutes} Minuten");
  }
}

public static class MediaDemoLoesung
{
  public static void Start()
  {
    List<MediaItem> media = new List<MediaItem>
    {
      new Book("Clean Code", "Robert C. Martin"),
      new Book("The Pragmatic Programmer", "Andrew Hunt"),
      new Magazine("c't", 12),
      new Magazine("dotnetpro", 5),
      new DVD("Inception", 148),
      new DVD("The Matrix", 136)
    };

    PrintAll(media);
  }

  public static void PrintAll(List<MediaItem> items)
  {
    foreach (MediaItem item in items)
    {
      item.PrintInfo();
    }
  }
}
