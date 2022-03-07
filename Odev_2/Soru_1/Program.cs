// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

int sayi;
ArrayList asal = new ArrayList();
ArrayList asaldegil = new ArrayList();
for (int j= 0; j < 20; j++)
{

    bool durum = true;
Console.Write("Bir sayı girin: ");
String value = Console.ReadLine();

bool isNumeric=int.TryParse(value,out int r);
if(!isNumeric)
{
    j--;
    Console.Write("Hatalı giriş yaptınız  yeniden giriniz: ");
    continue;
}
sayi = int.Parse(value);
if (sayi<0)
{
    j--;
    Console.Write("Negatif bir sayı girdiniz yeniden giriniz: ");
    continue;
}

for (int i = 2; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        durum = false;
        break;
    }
}
// 1 ve 2 de döngüye girilemediğinde durum true olacak ve asaldırlar.
if (durum == false)
{
    asaldegil.Add(sayi);

}
else
{
    asal.Add(sayi);
}

}


asal.Sort();
asal.Reverse();

asaldegil.Sort();
asaldegil.Reverse();

int asalToplam =0;
int asaldegilToplam = 0;
foreach (var item in asal)
{
    asalToplam= asalToplam + int.Parse(item.ToString());
    
}

foreach (var item in asaldegil)
{
    asaldegilToplam= asaldegilToplam+int.Parse(item.ToString());
    
}

int asalSayisi = asal.Count;
int asaldegilSayisi = asaldegil.Count;
double asalOrtalama=0.0;
double asaldegilOrtalama=0.0;
if(asalSayisi>0){
 asalOrtalama = asalToplam/asalSayisi;
}
if(asaldegilSayisi>0){
asaldegilOrtalama = asaldegilToplam / asaldegilSayisi;

}
 
Console.WriteLine("Asal Sayıların SAyısı = "+asalSayisi);
Console.WriteLine("Asal Sayıların Ortalaması="+(asalOrtalama));
Console.WriteLine("Asal olmayanların Sayısı ="+asaldegilSayisi);
Console.WriteLine("Asal olmayanların ortalaması ="+(asaldegilOrtalama));

