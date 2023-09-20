internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a String : ");
        string input = Convert.ToString(Console.ReadLine());
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                result += c;
            }
        }

        Console.WriteLine(result);
    }
}