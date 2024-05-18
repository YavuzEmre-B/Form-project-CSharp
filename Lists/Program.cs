using System;

class Program
{
    static void Main()
    {
        string[] sehirler = new string[] { "Ankara", "Istanbul", "Izmir" };
        Console.WriteLine(sehirler.Length);

        sehirler = new string[4];
        sehirler[3] = "Bursa";
        foreach (var sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        List<string> sehirler2 = new List<string>() { "Ankara", "Istanbul", "Izmir" };
        sehirler2.Add("Bursa");
        sehirler2.Add("Manisa");
        sehirler2.Remove(sehirler2[2]);
        Console.WriteLine(sehirler2.Count);
        foreach (var sehir in sehirler2)
        {
            Console.WriteLine(sehir);
        }
        bool sonuc = sehirler2.Contains("Izmir");
        Console.WriteLine(sonuc);
    }
}
