
int sayi2, sayi1;

int toplam1 = 0;
int toplam2 = 0;

int min1 = int.MaxValue;
int min2 = int.MaxValue;

int deneme = int.MaxValue;
deneme += 1;
Console.WriteLine(deneme);
UInt32 deneme2 = UInt32.MaxValue;
deneme2 += 1;
Console.WriteLine(deneme2);
int deneme3 = int.MinValue; 
deneme3 -= 1;
Console.WriteLine(deneme3);

int max1 = 0;
int max2 = 0;

Console.Write("İlk sayıyı giriniz : ");
string strSayi1 = Console.ReadLine();
Console.Write("İkinci sayıyı giriniz : ");
sayi1 = Convert.ToInt32(strSayi1);
string strSayi2 = Console.ReadLine();
sayi2 = Convert.ToInt32(strSayi2);

for (int i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        if(i < min1 && i != 1)
        {
            min1 = i;
        }
        if(i > max1)
        {
            max1 = i;
        }
        toplam1 += i;
    }
}

for (int i = 1; i < sayi2; i++)
{
    if (sayi2 % i == 0)
    {
        if(i < min2 && i != 1)
        {
            min2 = i;
        }
        if (i > max2 )
        {
            max2 = i;
        }
        toplam2 += i;
    }
}
if(min1 == int.MaxValue)
{
    min1 = 0;
}
if (min2 == int.MaxValue)
{
    min2 = 0;
}

if (toplam1 == sayi2 && toplam2 == sayi1)
{
    Console.WriteLine("Bu iki sayı arkadaştır.");
}
else
{
    Console.WriteLine("Bu iki sayı arkadaş değildir.");
}
Console.WriteLine("İlk sayının en küçük böleni  : "+min1+ " \nİkinci sayının en küçük böleni : " + min2);
Console.WriteLine("İlk sayının en büyük böleni : " + max1 + " \nİkinci sayının en büyük böleni : " + max2);
