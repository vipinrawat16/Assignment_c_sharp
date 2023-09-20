internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a String : ");
        string input = Convert.ToString(Console.ReadLine());
        int a = 0;
        int b = input.Length - 1;
        bool check = true;
        while (a < b)
        {
            if (input[a] != input[b])
            {
                check = false;
                break;
                //Vipin
            }
            a++;
            b--;
        }
        if (check)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("its not a palindrome");
        }
        Console.ReadLine();
    }
}