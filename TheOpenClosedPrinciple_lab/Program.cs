using TheOpenClosedPrinciple_lab;

public class Program
{
    private static void Main(string[] args)
    {
        Chef chef = new Chef();
        CookingPilaf pilaf = new CookingPilaf();
        chef.Cooking(pilaf);
        CookingLasagna lasanga = new CookingLasagna();
        chef.Cooking(lasanga);
    }
}
