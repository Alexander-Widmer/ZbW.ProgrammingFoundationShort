namespace ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils;

/// <summary>Lösung: statische Mathe-Hilfsbibliothek.</summary>
public static class MathUtilsLoesung
{
  public static readonly double GoldenRatio = (1 + Math.Sqrt(5)) / 2;

  public static bool IsPrime(int n)
  {
    if (n < 2)
    {
      return false;
    }

    for (int i = 2; (long)i * i <= n; i++) // long: i * i würde bei grossem n überlaufen
    {
      if (n % i == 0)
      {
        return false;
      }
    }

    return true;
  }

  public static long Factorial(int n)
  {
    if (n < 0 || n > 20)
    {
      throw new ArgumentOutOfRangeException(nameof(n), "n muss zwischen 0 und 20 liegen.");
    }

    long result = 1;
    for (int i = 2; i <= n; i++)
    {
      result *= i;
    }

    return result;
  }

  public static double[] GenerateLinspace(double start, double end, int count)
  {
    if (count < 2)
    {
      throw new ArgumentException("count muss mindestens 2 sein.", nameof(count));
    }

    double[] result = new double[count];
    double step = (end - start) / (count - 1);
    for (int i = 0; i < count; i++)
    {
      result[i] = start + i * step;
    }

    return result;
  }
}
