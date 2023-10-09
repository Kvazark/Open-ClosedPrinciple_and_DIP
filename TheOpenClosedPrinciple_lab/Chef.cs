namespace TheOpenClosedPrinciple_lab;

public class Chef
{
    public string Name { get; set; }

    public void GoOutToTheGuests(){}
    public void Cooking(ICooking cooking)
    {
        cooking.PrepareADish();
    }
}