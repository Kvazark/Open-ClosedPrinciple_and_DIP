namespace BeforeTheOpenClosedPrinciple;

public class Chef
{
    public List<string> products1 { get; set; }
    public List<string> products2 { get; set; }
    
    public void PrepareADish1()
    {
        Console.WriteLine("Приготовление блюда 1...\nБлюдо 1 готово.");
    }
    public void PrepareADish2()
    {
        Console.WriteLine("Приготовление блюда 2...\nБлюдо 2 готово.");
    }
}