namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        GiftBox address = GiftBoxMaker("A 친구야 어떻게 지내고 있니", 150000);
        Console.WriteLine($"{address.Letter} {address.Money}");
    }

    static GiftBox GiftBoxMaker(string letter, int money)
    {
        GiftBox address = new GiftBox()
        {
            Letter = letter,
            Money = money
        };
        return address;
    }
}