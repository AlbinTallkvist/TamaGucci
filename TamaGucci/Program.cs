System.Console.WriteLine("Vänligen, välj ett namn för din Tamagotchi");
Tamagotchi Tamagotchi = new Tamagotchi();
Tamagotchi.namn = Console.ReadLine();



while (Tamagotchi.lives() == true)
{
  Tamagotchi.stats();
  Console.WriteLine("Va villdu?");
  Console.WriteLine($"1. Prata med {Tamagotchi.namn}");
  Console.WriteLine($"2. Mata {Tamagotchi.namn}");
  Console.WriteLine($"3. Lär {Tamagotchi.namn} nytt ord");
  System.Console.WriteLine("-------------------------------");



  string action = Console.ReadLine();
  if (action == "1")
  {
    Tamagotchi.Hi();
  }


  if (action == "2")
  {
    Tamagotchi.Feed();
  }


  if (action == "3")
  {
    Console.WriteLine("Ord?");
    string ord = Console.ReadLine();
    Tamagotchi.Teach(ord);

  }



  Tamagotchi.Tick(); 
}

Console.WriteLine($"{Tamagotchi.namn} dog!");
Console.ReadLine();