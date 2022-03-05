// See https://aka.ms/new-console-template for more information

using System;

namespace operatorler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Atama***");
        //atama ve işlemli atama
        int x = 3;
        int y = 3;
        y = y + 2;

        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        Console.WriteLine("***Mantıksal***");
        //mantıksal 

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted)
            Console.WriteLine("Perfect!");
        if (isSuccess || isCompleted)
            Console.WriteLine("Great!");
        if (isSuccess && !isCompleted)
            Console.WriteLine("Fine!");

        Console.WriteLine("***İlişkisel Operatörler!***");
        //ilişkisel operatörler

        int a = 3;
        int b = 4;
        bool sonuc = a < b;

        Console.WriteLine(sonuc);
        sonuc = a > b;
        Console.WriteLine(sonuc);
        sonuc = a >= b;
        Console.WriteLine(sonuc);
        sonuc = a <= b;
        Console.WriteLine(sonuc);
        sonuc = a == b;
        Console.WriteLine(sonuc);
        sonuc = a != b;











    }
}

        