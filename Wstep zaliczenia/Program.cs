using ConsoleApp2;




Main.Chickens = 200;
float FoodPrice = 1.9F;
float ChickenPerDay = 0.2F;
int x = 1;



while (x < 181)
{
    var Today = Main.Chickens * ChickenPerDay;
    var ForFood = Today * FoodPrice;
    Main.Balance = Main.Balance - ForFood;

    if (Main.Is30(x))
    {
        var NeedToBuy = Main.Chickens * 0.2;
        Convert.ToInt32(NeedToBuy);
        var Pay = NeedToBuy * 18;
        Main.Balance = Main.Balance - Pay;
        Main.Chickens = Main.Chickens + Convert.ToInt32(NeedToBuy);
        Main.pasze = Main.pasze + Pay;

    }
    if (Main.Sunday(x))
    {
        var EggsThisDay = Main.Chickens * 1;
        double PerDay = EggsThisDay * 0.9;
        Main.Balance = Main.Balance + PerDay;
    }


    if (Main.Fox(x))
    {
        Main.Chickens = Main.Chickens - 2;
    }

    x++;

    Console.WriteLine("________________________________");
    Console.WriteLine($"Today is {x - 1} day");
    Console.WriteLine($"Bank balance {Convert.ToInt32(Main.Balance)}");
    Console.WriteLine($"Chickens {Main.Chickens}");
    Console.WriteLine($"For food {ForFood}");
    Console.WriteLine("________________________________");
}
Console.WriteLine($"a) 33");
Console.WriteLine($"b) Total : {Main.pasze}");
Console.WriteLine($"c) po 180 dniach {Main.Balance}");
