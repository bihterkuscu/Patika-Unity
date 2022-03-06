// See https://aka.ms/new-console-template for more information
using System;
namespace döngüler_while_foreach{
    

class Program
{
    static void Main(string[] args)
    {
       //while  
       //1 den baslayarak console dan girilen sayiya kadar(sayi dahil) ortalama hesaplayip console a yazdiran program
       Console.WriteLine("Lütfen bir sayi giriniz:");
       int sayi =int.Parse(Console.ReadLine());
       int sayac =1;
       int toplam =0;
       while(sayac<=sayi){
           toplam+=sayac;
           sayac ++;
       }
       Console.WriteLine("toplam/sayi");
    
      //'a' dan z ye kadar tüm harfleri console yazdır
      char character ='a';
      while(character < 'z')
      {
        Console.Write(character);
        character ++;
      }  
      Console.WriteLine("**Foreach*");
      string[] arabalar ={"BMW","Ford","Toyota","Nissan"};
      foreach (var araba in arabalar){
          Console.WriteLine(araba);
      }
      
      
         }
      }
   }
