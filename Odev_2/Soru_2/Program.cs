// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;

public static class MinMaxAverage
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write(i + 1 + ".nci sayiyi girin: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);

        int[] biggest3 = new int[3];
        int[] smallest3 = new int[3];

        Array.Copy(numbers, numbers.Length - 3, biggest3, 0, 3);
        Array.Copy(numbers, smallest3, 3);

        Console.WriteLine("En BUYUK 3 sayının ortalaması: " + GetAverage(biggest3));
        Console.WriteLine("En KUCUK 3 sayının ortalaması: " + GetAverage(smallest3));
        Console.WriteLine("Ortalamalarin toplamı: " + (GetAverage(biggest3) + GetAverage(smallest3)));
    }
    private static float GetAverage(int[] nums)
    {
        return (float)nums.Sum() / (float)nums.Length;
    }
}
