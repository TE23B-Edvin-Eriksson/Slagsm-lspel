// Start HP för Championsen och start stringsen
int champion1hp = 10;
int champion2hp = 10;
int rounds = 1;

string champion1;
string champion2;

// Namn för champions
Console.WriteLine("Skriv namn för 2 olika champions.");
champion1 = Console.ReadLine();
champion2 = Console.ReadLine();
while (champion1 == "" || champion2 == "") // Loopar tills man får något slags namn
{
   if (champion1 == "")
   {
      Console.WriteLine("Försök Igen:");
      Console.WriteLine("Du måste skriva in namn för champion 1");
      champion1 = Console.ReadLine();
   }
   if (champion2 == "")
   {
      Console.WriteLine("Försök Igen:");
      Console.WriteLine("Du måste skriva in namn för champion 1");
      champion2 = Console.ReadLine();
   }
}


// Intro och påbörjan av koden

Random random = new Random();

Console.WriteLine($"Välkommen till UFC 420 där {champion1} och {champion2} möts i en episk strid!");
Console.WriteLine($"{champion1} har {champion1hp} hp!");
Console.WriteLine($"{champion2} har {champion2hp} hp!");
while (champion1hp > 0 || champion2hp > 0)
{
   Console.WriteLine($"Round {rounds}");
      Console.WriteLine($"{champion1} har {champion1hp} kvar");
      Console.WriteLine($"{champion2} har {champion2hp} kvar");
   int damageToChamp2 = Random.Shared.Next(1, 4); // Väljer mellan 1-3 damage för 4 är max numret och den tar inte det som ett val
   champion2hp -= damageToChamp2; // Damage från champions hp
      Console.WriteLine($"{champion1} slår {champion2} för {damageToChamp2} skada! {champion2} har {Math.Max(0, champion2hp)} HP kvar.");
   Thread.Sleep(1000);
   int damageToChamp1 = Random.Shared.Next(1, 4); // Väljer mellan 1-3 damage för 4 är max numret och den tar inte det som ett val
   champion1hp -= damageToChamp1;// Damage från champions hp
      Console.WriteLine($"{champion2} slår {champion1} för {damageToChamp1} skada! {champion1} har {Math.Max(0, champion1hp)} HP kvar.");
   Thread.Sleep(1000);
   rounds += 1;
}

Console.ReadLine();


