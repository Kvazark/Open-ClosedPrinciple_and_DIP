namespace TheOpenClosedPrinciple_lab;

public class RoutePermutation: IEncryption
{
    public string text { get; set; }
    public void Encrypt()
    {
        //какая-то реализация
        Console.WriteLine(text+" - Маршрутная перестановка");
    }
}