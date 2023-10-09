namespace TheOpenClosedPrinciple_lab;

public class CookingLasagna:ICooking
{
    public List<string> products { get; set; }

    public void PrepareADish()
    {
        Console.WriteLine("Приготовление лазаньи...\nБлюдо готово.");
    }
}