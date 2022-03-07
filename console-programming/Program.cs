// See https://aka.ms/new-console-template for more information
using System;

namespace console_programming;

internal class NewBaseType
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hi My Name Bihter!");
        Console.WriteLine("İsim:");
        string name = Console.ReadLine();
        Console.WriteLine("Soyisim:");
        string surname = Console.ReadLine();

        Console.WriteLine("Merhaba" + name + "" + surname);


    }
}
