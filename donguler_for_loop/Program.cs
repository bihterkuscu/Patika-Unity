// See https://aka.ms/new-console-template for more information
using System;

 class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Lütfen bir sayi giriniz:");
        int sayac =int.Parse(Console.ReadLine());
        for (int i=1;i <=sayac;i++){
            if (i%2 == 1)
            Console.WriteLine(i);
            
        }
        int tekToplam =0;
        int ciftToplam =0;
        for (int i=1;i <=1000;i++)
        {
            if (i%2 == 1)
            tekToplam+=i;
            else
            tekToplam+=i;
                
            
        }
        Console.WriteLine("Tek Toplam:"+ tekToplam);
        Console.WriteLine("Cift Toplam:"+ ciftToplam);
        for (int i=1;i<10;i++)
        {
            if(i==4)
              continue;
            Console.WriteLine(i);
          }
       }
    }

