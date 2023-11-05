using System;

class Program
{
    static void Main()
    {
        int sayi1 = 220;
        int sayi2 = 284;

        if (ArkadasSayiMi(sayi1, sayi2))
        {
            Console.WriteLine($"{sayi1} ve {sayi2} arkadaþ sayýlardýr.");
        }
        else
        {
            Console.WriteLine($"{sayi1} ve {sayi2} arkadaþ sayý deðildir.");
        }
    }

    static bool ArkadasSayiMi(int sayi1, int sayi2)
    {
        return ToplamBolenleriHesapla(sayi1) == sayi2 && ToplamBolenleriHesapla(sayi2) == sayi1;
    }

    static int ToplamBolenleriHesapla(int sayi)
    {
        int toplam = 0;
        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam += i;
            }
        }
        return toplam;
    }
}
