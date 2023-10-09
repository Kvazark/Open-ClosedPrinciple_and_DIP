using TheOpenClosedPrinciple_lab;

public class Program
{
    private static void Main(string[] args)
    {
        CookingPilaf pilaf = new CookingPilaf();
        pilaf.PrepareADish();
        CookingLasagna lasanga = new CookingLasagna();
        lasanga.PrepareADish();
    }
}
