// Start HP för champions och startvariabler
int champion1hp = 10;
int champion2hp = 10;
int rounds = 1;

string champion1;
string champion2;

// Namn för champions
Console.WriteLine("Skriv namn för 2 olika champions.");
champion1 = Console.ReadLine();
champion2 = Console.ReadLine();

// Loop tills båda champions har giltiga namn
while (champion1 == "" || champion2 == "")
{
   if (champion1 == "")
   {
      Console.WriteLine("Försök igen: Du måste skriva in namn för champion 1");
      champion1 = Console.ReadLine();
   }
   if (champion2 == "")
   {
      Console.WriteLine("Försök igen: Du måste skriva in namn för champion 2");
      champion2 = Console.ReadLine();
   }
}

// Intro och start av striden
Console.WriteLine($"Välkommen till UFC 420 där {champion1} och {champion2} möts i en episk strid!");
Console.WriteLine($"Båda {champion1} och {champion2} börjar med {champion1hp} HP!");

// Startar striden
while (champion1hp > 0 && champion2hp > 0)
{
   Console.WriteLine($"\n--- Round {rounds} ---");
   Console.WriteLine($"{champion1} har {champion1hp} HP kvar.");
   Console.WriteLine($"{champion2} har {champion2hp} HP kvar.");

   // Slagskämpe 1 slår slagskämpe 2
   int damageToChamp2 = Random.Shared.Next(1, 4); // Slumpa skada mellan 1 och 3
   champion2hp -= damageToChamp2;
   Console.WriteLine($"{champion1} slår {champion2} för {damageToChamp2} skada! {champion2} har {Math.Max(0, champion2hp)} HP kvar.");

   // Kontrollera om champion2 har förlorat allt HP
   if (champion2hp <= 0)
   {
      Console.WriteLine("___________________________________________________");
      Console.WriteLine($"{champion1} vinner matchen! {champion2} är utslagen!");
      break;
   }

   // Paus för spänning
   Thread.Sleep(1000);

   // Slagskämpe 2 slår slagskämpe 1
   int damageToChamp1 = Random.Shared.Next(1, 4); // Slumpa skada mellan 1 och 3
   champion1hp -= damageToChamp1;
   Console.WriteLine($"{champion2} slår {champion1} för {damageToChamp1} skada! {champion1} har {Math.Max(0, champion1hp)} HP kvar.");

   // Kontrollera om champion1 har förlorat allt HP
   if (champion1hp <= 0)
   {
      Console.WriteLine("___________________________________________________");
      Console.WriteLine($"{champion2} vinner matchen! {champion1} är utslagen!");
      break;
   }

   // Paus för spänning
   Thread.Sleep(1000);

   // Öka runda
   rounds++;
}

// Kontroll för oavgjort (om båda når 0 HP samtidigt)
if (champion1hp <= 0 && champion2hp <= 0)
{
   Console.WriteLine("___________________________________________________");
   Console.WriteLine("Det blev oavgjort! Båda slagskämparna föll samtidigt!");
}
Console.ReadLine();