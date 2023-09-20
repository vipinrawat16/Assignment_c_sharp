internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String");
        string inputStr = Convert.ToString(Console.ReadLine());
        
        string vowel = "AEIOUaeiou";
        string result = "";

        foreach (char c in inputStr)
        {
            if (vowel.IndexOf(c) == -1)
            {
                result += c;
            }
        }
        Console.WriteLine(result);
    }
}
