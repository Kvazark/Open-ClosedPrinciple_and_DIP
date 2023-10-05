namespace TheOpenClosedPrinciple_lab;

public class RotatingGrid:IEncryption
{
    public string text { get; set; }
    public void Encrypt()
    {
        //какая-то реализация
        Console.WriteLine(text+" - Вращающаяся решётка");
    }
    
}