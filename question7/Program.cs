internal class Program
{
    public static void Main(string[] args)
    {
        string input = "take u forward is awesome";
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 2)
            {
                char[] chars = words[i].ToCharArray();
                chars[0] = char.ToUpper(chars[0]); // Capitalize first character
                chars[chars.Length - 1] = char.ToUpper(chars[chars.Length - 1]); // Capitalize last character
                words[i] = new string(chars);
            }
        }

        string result = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            result += " " + words[i];
        }
        Console.WriteLine(result);

    }
}
