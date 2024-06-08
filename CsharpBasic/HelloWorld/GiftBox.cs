using Defines;

namespace HelloWorld;

class GiftBox 
{
    public readonly char FirstLetter;
    public readonly string Letter;
    public int Money;
    public ItemGrade Grade {get;set;}

    GiftBox(char firstLetter, string letter, int money, ItemGrade grade) 
    {
        FirstLetter = firstLetter;
        Letter = letter;
        Money = money;
        Grade = grade;
    }


    public static GiftBox NewBox(char firstLetter, string letter, int money)
    {
        return new GiftBox(firstLetter, letter, money, ItemGrade.NORMAL);
    }
}

