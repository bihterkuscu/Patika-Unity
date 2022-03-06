// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

 class program
{
    static void Main(string[] args)
    {
       ArrayList liste =new ArrayList();
       //liste.Add("Ayse");
       //liste.Add(2);
       // liste.Add(true);
       // liste.Add("A");

       //İçerisindeki verilere erişim
       // Console.WriteLine(liste[1]);
//        foreach(var item in liste);
//        Console.WriteLine(item);
       //Add Range
       Console.WriteLine("**Add Range*");
       //string[] renkler ={"kırmızı","sarı","yesil"};
       List<int> sayilar =new List<int>(){1,8,3,7,9,92,5};
       //liste.AddRange(renkler);
       liste.AddRange(sayilar);

       foreach(var item in liste)
         Console.WriteLine(item);

        //Sort
        Console.WriteLine("**Sort*");
        liste.Sort();
        foreach(var item in liste )
           Console.WriteLine(item);

        //Binary Search 
        Console.WriteLine("***Binary Search");
        Console.WriteLine(liste.BinarySearch(9));

        //Reverse
        Console.WriteLine("reverse");
        liste.Reverse();

        foreach(var item in liste)
          Console.WriteLine(item);
         
        //clear 
        Console.WriteLine("Clear");
        foreach(var item in liste)
            Console.WriteLine(item);

            


                
    }}
