namespace TheOpenClosedPrinciple_lab;

public class CookingPilaf:IChef
{
    public List<string> products { get; set; }

    public void PrepareADish()
    {
        Console.WriteLine("Приготовление плова...\nБлюдо готово.");
    }
}