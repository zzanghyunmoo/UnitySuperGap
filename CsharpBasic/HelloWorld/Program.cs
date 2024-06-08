using Defines;

namespace HelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        GiftBox box = GiftBox.NewBox('A', "A 친구야 어떻게 지내고 있니", 150000);
        List<GiftBox> boxes = [box];

        for (int i = 0; i < boxes.Count; i++) {
            GiftBox b = boxes[i];
            Console.WriteLine($"변경 전 [겉면: {b.FirstLetter}, 본면: {b.Letter} {b.Money} {b.Grade}]");
            b.Grade = ItemGrade.UNIQUE;
            Console.WriteLine($"변경 후 [겉면: {b.FirstLetter}, 본면: {b.Letter} {b.Money} {b.Grade}]");
        }
 
        boxes.Clear();

        foreach (var b in boxes){
            Console.WriteLine($"겉면: {b.FirstLetter}, 본면: {b.Letter} {b.Money} {b.Grade}");
        }

        string numString = "십오";
        bool isParse = int.TryParse(numString, out int num);
        Console.WriteLine($"변경 여부: {isParse} 문자열 {numString} 값: {num}");

        numString = "150";
        isParse = int.TryParse(numString, out num);
        Console.WriteLine($"변경 여부: {isParse} 문자열 {numString} 값: {num}");

        int primitiveType = num;
        Console.WriteLine($"복사 후 변경 전: num: {num}, primitiveType: {primitiveType}");
        primitiveType = 250;
        Console.WriteLine($"복사 후 변경 후: num: {num}, primitiveType: {primitiveType}");
        

        GiftBox referenceType = box;
        Console.WriteLine($"복사 후 변경 전: box.money: {box.Money}, referenceType: {referenceType.Money}");
        referenceType.Money = 999999;
        Console.WriteLine($"복사 후 변경 후: box.money: {box.Money}, referenceType: {referenceType.Money}");
    }
}