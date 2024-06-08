using System.Reflection.Metadata;

namespace StringManipulation;

class Program
{
    static void Main(string[] args)
    {
        string letter = "  친구야 잘 지내니  ";
        bool isContain = letter.Contains("지내");
        Console.WriteLine(isContain);

        string replacedLetter = letter.Replace("친구야", "륜희야");
        Console.WriteLine(replacedLetter);

        // TrimStart: 앞에 공백 제거
        // TrimEnd: 뒤에 공백 제거
        // Trim: 앞 뒤 공백 제거
        string trimmedLetter = replacedLetter.Trim();
        Console.WriteLine(trimmedLetter);
        
        // string subLetter = trimmedLetter.Substring(1, 3); 
        string subLetter = trimmedLetter[1..3];
        Console.WriteLine(subLetter);

        letter = "여진,민재,호동";
        string[] splitLetter = letter.Split(",");
        Console.WriteLine($"split {letter}");
        foreach (string s in splitLetter)
        {
            Console.WriteLine(s);
        }
 
        letter = "Hi Friends!";
        string lowerLetter = letter.ToLower();
        Console.WriteLine(lowerLetter);

        string upperLetter = letter.ToUpper();
        Console.WriteLine(upperLetter);
    }
}
