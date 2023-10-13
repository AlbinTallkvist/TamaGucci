public class Tamagotchi
{
  private int hunger;
  private int boredom;
  private List<string> ordbank = new List<string>() {"vaa händerr kompis"};
  public string namn;
  private bool levandes;
  private Random generator;

  public Tamagotchi()
  {
    levandes = true;
    generator = new Random();
  }

  // statsn
  public void stats() 
  {
    System.Console.WriteLine($"Namn: {namn}");
    System.Console.WriteLine($"Hunger: {hunger}"); 
    System.Console.WriteLine($"Boredom: {boredom}");
    System.Console.WriteLine($"Ordbank: {ordbank.Count}"); 
    System.Console.WriteLine("-------------------------------");
  }

  // gör om till bool  så kan ändra till död on off
  public bool lives()
  {

    return levandes;
  }

  public void Feed()
  {
    int slumpadMängd = generator.Next(1, 4); // slumpa hunger värdet (bonusstings)
    System.Console.WriteLine($" [{namn}] åt och hungern minskade med {slumpadMängd}");
    hunger -= slumpadMängd;

    if (hunger < 0)
    {
      hunger = 0;
    }
  }

  public void MinskaBoredom()
  {
    int slumpadBoredom= generator.Next(1, 3); // slumpa boredom värdet (bonuss)
    System.Console.WriteLine($" [{namn}] boredness sjönk med {slumpadBoredom}");
    hunger -= slumpadBoredom;



    if (boredom < 0)
    {
      boredom = 0;
    }
  }

  public void Hi()
  {
    int antalord = generator.Next(ordbank.Count);

    System.Console.WriteLine($" [{namn}] sa: {ordbank[antalord]}");
    MinskaBoredom();
  }

  public void Teach(string ord)
  {
    System.Console.WriteLine($" [{namn}] lärde sig: {ord}");
    ordbank.Add(ord);

    MinskaBoredom();
  }

  public void Tick()
  {
    hunger++;
    boredom++;
    
    // om tamagotchins hunger eller boredom blir för mycke dör
    if (hunger > 9 || boredom > 9)
    {
      levandes = false;
    }
  }
}