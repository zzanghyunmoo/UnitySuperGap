using System.Text;

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
        foreach (var splitted in splitLetter)
        {
            Console.WriteLine(splitted);
        }
 
        letter = "Hi Friends!";
        string lowerLetter = letter.ToLower();
        Console.WriteLine(lowerLetter);

        string upperLetter = letter.ToUpper();
        Console.WriteLine(upperLetter);

        var name = "륜희";
        var point = 50000000.9289;
        // plain string
        Console.WriteLine(name + " 고객님, 적립금 " + point + "원이 남았습니다.");
        // string.Format
        Console.WriteLine(string.Format("{0} 고객님, 적립금 {1:C}원이 남았습니다.", name, string.Format("{0:0.00}", point)));
        // string interpollation
        Console.WriteLine($"{name} 고객님, 적립금 {Math.Round(point, 2)}원이 남았습니다.");
        // stringbuilder
        var sb = new StringBuilder();
        sb.Append(name);
        sb.Append(" 고객님, 적립금 ");
        sb.Append(string.Format("{0:0.00}", point));
        sb.Append("원이 남았습니다.");
        System.Console.WriteLine(sb.ToString());

        System.Console.WriteLine($"Local: {DateTime.Now}");
        System.Console.WriteLine($"UTC: {DateTime.UtcNow}");

        var utc = DateTime.UtcNow;
        System.Console.WriteLine($"toLocal {utc.ToLocalTime()}");
        var local = DateTime.Now;
        System.Console.WriteLine($"toUTC {local.ToUniversalTime()}");

        var utcTimestamp = DateTimeOffset.UtcNow;
        System.Console.WriteLine($"{utcTimestamp} utc: {utcTimestamp.UtcDateTime}, local: {utcTimestamp.LocalDateTime}");

        System.Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        System.Console.WriteLine(local.AddHours(3).AddMinutes(-5).ToString("yyyy-MM-dd HH:mm:ss"));

        var ts = utc - utc.AddHours(-9);
        Console.WriteLine(ts);
    }
}
