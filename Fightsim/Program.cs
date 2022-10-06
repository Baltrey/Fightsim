// See https://aka.ms/new-console-template for more information
Random generator = new Random();
string mc = "";
string ac = "";
while (true)
{
    Console.WriteLine("Hej välkommen till mitt fighting sim!!!");
    Console.WriteLine("Vill du vara warrior(1) eller goblin(2)");
    string mcanswer = Console.ReadLine();
    if (mcanswer == "1")
    {
        mc = "Warrior";
        ac = "Goblin";
    }
    else
    {
        mc = "Goblin";
        ac = "Warrior";
    }
    int mchealth = 100;
    int achealth = 100;
    int mcattack = 0;
    int acattack = 0;
    Console.WriteLine($"Okej du är en {mc}!!!");
    Console.WriteLine($"{mc}börjar");
    while (mchealth > 0 && achealth > 0)
    {
        mcattack = generator.Next(1, 11);
        Console.WriteLine($"Du slog {ac} för {mcattack} skada");
        achealth = achealth - mcattack;
        Console.WriteLine($"{ac} har nu {achealth} hälsa kvar");
        Thread.Sleep(200);
        acattack = generator.Next(1, 11);
        Console.WriteLine($"{ac} slog dig för {acattack} skada");
        mchealth = mchealth - acattack;
        Console.WriteLine($"Du har nu {mchealth} hälsa kvar");
        Thread.Sleep(200);
    }
    if (achealth < mchealth)
    {
        Console.WriteLine("Du vann!!!");
    }
    if (mchealth < achealth)
    {
        Console.WriteLine($"{ac} Vann!!!");
    }
    else if (mchealth < 0 && achealth < 0)
    {
        Console.WriteLine("ingen vann det blev lika!!!");
    }
    Console.WriteLine("Vill du köra igen [Y or N]");
    bool tocontinue = false;
    bool invalidanswer = true;

    while (invalidanswer)
    {

        string answer = Console.ReadLine().ToUpper();
        if (answer == "Y")
        {
            tocontinue = true;
            invalidanswer = false;
        }
        else if (answer == "N")
        {
            invalidanswer = false;
        }
    }
    if (tocontinue != true) return;
}


