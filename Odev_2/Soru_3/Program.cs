// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class FindVowels
{
    public static void Main(string[] args)
    {
        var vowels = new List<char>() {'a', 'e', 'i', 'o', 'u'};
        var vowelsFound = new List<char>();

        Console.WriteLine("Metni Giriniz:");
        string sentence = Console.ReadLine();
		
        foreach (char c in sentence)
        {
            if (vowels.Contains(c))
            {
                vowelsFound.Add(c);
                Console.WriteLine(c);
            }
        }
    }
}
