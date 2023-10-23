namespace BeforeDIP;

public class Restaurant
{
    private Cheif _cheif;

    public Restaurant()
    {
        _cheif = new Cheif();
    }

    public void ServeTheDish()
    {
        _cheif.Cooking();
    }

}