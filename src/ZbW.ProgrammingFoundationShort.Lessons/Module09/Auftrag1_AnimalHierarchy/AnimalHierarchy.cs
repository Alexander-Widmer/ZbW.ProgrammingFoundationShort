namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy;

// ============================================================
// AUFTRAG 1 – Animal Hierarchy (⭐ Einfach | ~15 Min.)
//
// Entwirf die Hierarchie selbst – hier steht nur die Startmethode.
//
// Anforderungen:
//   - Basisklasse Animal: Name, Age; Konstruktor Animal(string name, int age)
//     virtual string MakeSound() → "...", override ToString() → "Bello, 3 Jahre"
//   - Dog : Animal mit zusätzlicher Property Breed
//     Konstruktor Dog(name, age, breed) : base(name, age)
//     MakeSound() → "Wuff!", ToString() erweitert base.ToString() um die Rasse
//   - Cat ("Miau!") und Bird ("Piep!") mit eigenem Konstruktor und base(...)
//   - Start(): List<Animal> mit je 2 Tieren, foreach → "Bello, 3 Jahre, Labrador: Wuff!"
// ============================================================

// TODO 1: Klasse Animal

// TODO 2: Klasse Dog

// TODO 3: Klassen Cat und Bird

public static class AnimalHierarchy
{
  public static void Start()
  {
    // TODO 4: List<Animal> mit je 2 Hunden, Katzen und Vögeln füllen
    // TODO 5: foreach über die Liste: Tier und MakeSound() ausgeben (Polymorphismus)
  }
}
