using System;



class Program
{
    static void Main()
    {
        Math math = new Math();
        int sonuc1 = math.Topla(2, 3);
        int sonuc2 = math.Topla(3, 63, 25);
        int sonuc3 = math.Topla(sayi2: 65, sayi1: 10);
        int sonuc4 = math.ToplaParams(1, 3, 45, 5, 6, 67);
        int sonuc5 = math.ToplaParams(new int[] { 1, 2, 3, 4, 5, });
    }
}

//overloading
class Math
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public int Topla(int sayi1, int sayi2, int sayi3)
    {
        return sayi1 + sayi2 + sayi3;
    }

    public int ToplaParams(params int[] sayilar)
    {
        int sonuc = 0;
        foreach (var sayi in sayilar)
        {
            sonuc += sayi;
        }
        //return sayilar.Sum();
        return sonuc;
    }

    public int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}