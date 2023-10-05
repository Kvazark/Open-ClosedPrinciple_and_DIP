using TheOpenClosedPrinciple_lab;

public class Program
{
    private static void Main(string[] args)
    {
        EncryptText encryptText = new EncryptText();
        RotatingGrid cipher1 = new RotatingGrid{text="test"};
        encryptText.Encrypt(cipher1);
        RoutePermutation cipher2 = new RoutePermutation{text="test2"};
        encryptText.Encrypt(cipher2);
    }
}