internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Enter a String : ");
        string input = Convert.ToString(Console.ReadLine());
        string a = "";

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                a += c;
            }
        }
        Console.WriteLine(a);
    }
}