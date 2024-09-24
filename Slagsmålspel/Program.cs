
// Start HP för slagskämparna och start stringsen
int champion1hp = 10;
int champion2hp = 10;

string champion1;
string champion2;

// Namn
Console.WriteLine("Skriv namn för 2 olika champions.");
champion1 = Console.ReadLine();
champion2 = Console.ReadLine();
while (champion1 == " " || champion2 == "")
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

//Console.WriteLine($"Välkommen till UFC 420 där {champion1} och {champion2} möts i en episk strid!");

Console.ReadLine();

