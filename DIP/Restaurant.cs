namespace DIP;

public class Restaurant
{
    private ICheif _cheif;

    public Restaurant(ICheif cheif)
    {
        _cheif = cheif;
    }
    public void ServeTheDish()
    {
        _cheif.Cooking();
    }
}