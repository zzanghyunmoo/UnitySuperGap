namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        GiftBox box = GiftBoxMaker("A 친구야 어떻게 지내고 있니", 150000);
        List<GiftBox> boxes = [box];

        foreach (var b in boxes){
            Console.WriteLine($"{b.Letter} {b.Money}");
        }

        boxes.Clear();

        for (int i = 0; i < boxes.Count; i++) {
            var b = boxes[i];
            Console.WriteLine($"{b.Letter} {b.Money}");
        }
    }

    static GiftBox GiftBoxMaker(string letter, int money)
    {
        GiftBox address = new()
        {
            Letter = letter,
            Money = money
        };
        return address;
    }
}