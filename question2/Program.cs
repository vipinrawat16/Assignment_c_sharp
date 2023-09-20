﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Convert.ToString(Console.ReadLine());

        int vowelCount = 0;
        int consonantCount = 0;
        int spaceCount = 0;

        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                char lowerChar = char.ToLower(ch);

                if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            else if (char.IsWhiteSpace(ch))
            {
                spaceCount++;
            }
        }

        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
        Console.WriteLine("White spaces: " + spaceCount);

        Console.ReadLine();
    }
}