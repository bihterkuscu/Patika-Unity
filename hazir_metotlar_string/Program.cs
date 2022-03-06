// See https://aka.ms/new-console-template for more information
using System;

 class program
{
    static void Main(string[] args)
    {
        string degisken ="Dersimiz csharp, Hosgeldiniz";
        string degisken2 ="Csharp";
        //lenght
            Console.WriteLine(degisken.Length);
        //uppper tolower    
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
        //Concat   
                Console.WriteLine(String.Concat(degisken,"Merhaba"));
        //compare compareTo
                Console.WriteLine(degisken.CompareTo(degisken2));
                Console.WriteLine(String.Compare(degisken,degisken2,true));
                Console.WriteLine(String.Compare(degisken,degisken2,false));
        //contains
                Console.WriteLine(degisken.Contains(degisken2));
                Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
                Console.WriteLine(degisken.StartsWith("Merhaba!"));
        //indexof
                Console.WriteLine(degisken.IndexOf("CS"));
                Console.WriteLine(degisken.IndexOf("Zikriye"));
        //İnsert
                Console.WriteLine(degisken.Insert(0,"Merhaba"));
        //Padleft padright
                Console.WriteLine(degisken + degisken2.PadLeft(30));
                Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
                Console.WriteLine(degisken.PadRight(50)+degisken2);
                Console.WriteLine(degisken.PadRight(50,'-')+degisken2);  
        //Remove
                Console.WriteLine(degisken.Remove(10));
                Console.WriteLine(degisken.Remove(5,3));
                Console.WriteLine(degisken.Remove(0,1));
        //Replace
                Console.WriteLine(degisken.Replace("csharp","C#"));
                Console.WriteLine(degisken.Replace("","*"));
                
        //Split
                Console.WriteLine(degisken.Split("")[1]);
        //Substring
                Console.WriteLine(degisken.Substring(4));
                Console.WriteLine(degisken.Substring(4,6));









    }}