// See https://aka.ms/new-console-template for more information
using System;

 class program
{
    public static void Main(string[] args)
    {
        //sort
        int[] sayiDizisi ={23,12,4,86,72,3,11,17};
        Console.WriteLine ("**Sirasiz Dizi**");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine (sayi);

        Console.WriteLine ("**Sirali Dizi**");
        Array.Sort(sayiDizisi);
        //Clear
        Console.WriteLine("*Array Clear**");
        Array.Clear(sayiDizisi,2,2);
        foreach(var sayi in sayiDizisi)
        Console.WriteLine(sayi);
        //Reverse
        Console.WriteLine("Array Reverse");
        Array.Reverse(sayiDizisi);
        foreach(var sayi in sayiDizisi)
          Console.WriteLine(sayi);
        //İndexOf
        Console.WriteLine("Array İndexOf");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));
        //Resize
        Console.WriteLine("Array Resize");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach(var sayi in sayiDizisi)
         Console.WriteLine(sayi);


       }
    }

