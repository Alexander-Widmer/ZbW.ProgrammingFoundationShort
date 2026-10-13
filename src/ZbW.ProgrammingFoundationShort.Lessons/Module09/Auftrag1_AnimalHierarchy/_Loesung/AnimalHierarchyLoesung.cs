namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy._Loesung;

public class Animal
{
  public Animal(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public string Name { get; }
  public int Age { get; }

  public virtual string MakeSound()
  {
    return "...";
  }

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre";
  }
}

public class Dog : Animal
{
  public Dog(string name, int age, string breed) : base(name, age)
  {
    Breed = breed;
  }

  public string Breed { get; }

  public override string MakeSound()
  {
    return "Wuff!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, {Breed}";
  }
}

public class Cat : Animal
{
  public Cat(string name, int age) : base(name, age)
  {
  }

  public override string MakeSound()
  {
    return "Miau!";
  }
}

public class Bird : Animal
{
  public Bird(string name, int age) : base(name, age)
  {
  }

  public override string MakeSound()
  {
    return "Piep!";
  }
}

public static class AnimalHierarchyLoesung
{
  public static void Start()
  {
    List<Animal> animals = new List<Animal>
    {
      new Dog("Bello", 3, "Golden Retriever"),
      new Dog("Luna", 5, "Labrador"),
      new Cat("Mia", 2),
      new Cat("Nala", 4),
      new Bird("Kiki", 2),
      new Bird("Rio", 4)
    };

    foreach (Animal animal in animals)
    {
      Console.WriteLine($"{animal}: {animal.MakeSound()}");
    }
  }
}
