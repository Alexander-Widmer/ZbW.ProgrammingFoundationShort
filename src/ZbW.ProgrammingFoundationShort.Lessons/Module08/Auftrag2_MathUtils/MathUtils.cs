namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

/// <summary>Statische Mathe-Hilfsbibliothek – von dir zu implementieren.</summary>
public static class MathUtils
{
  // TODO 1: static readonly double GoldenRatio = (1 + √5) / 2  (Math.Sqrt)
  public static readonly double GoldenRatio = 0;

  public static bool IsPrime(int n)
  {
    // TODO 2: true, wenn n eine Primzahl ist (n < 2 ist keine Primzahl)
    return false;
  }

  public static long Factorial(int n)
  {
    // TODO 3: n! mit einer Schleife berechnen
    //         n < 0 oder n > 20 → ArgumentOutOfRangeException (long läuft ab 21! über)
    return 0;
  }

  public static double[] GenerateLinspace(double start, double end, int count)
  {
    // TODO 4: count gleichmässig verteilte Werte von start bis end (inklusive)
    //         count < 2 → ArgumentException
    return new double[0];
  }
}
