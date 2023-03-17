
using Ders10ÖzgenlerProperties;

internal class program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Özgenler -  Properties");
        Skorlar skorlar = new Skorlar();
        skorlar.Skor = 5;
        Console.WriteLine("Skor değeri : " + skorlar.Skor);
        kisi kisi = new kisi();
        kisi.Adi = "Memati";
        kisi.Soyadi = "Baş";
        kisi.Maas = 8000; // burada Maas propertysine veri gönderdiğimizde set bloğu çalışır.
        kisi.Yas = 17; 

        Console.WriteLine();
        Console.WriteLine("Personel Bilgileri :");
        Console.WriteLine($"Adı : {kisi.Adi} Soyadı : {kisi.Soyadi}");
        Console.WriteLine($"Maaş : {kisi.Maas} Yaş {kisi.Yas}"); // burada Maas  ve kişi propertylerini çağırdığımızda
        // property deki get bloğu çalışır.

        kisi.Maas = 18000; // burada Maas propertysine veri gönderdiğimizde set bloğu çalışır.
        kisi.Yas = 39;
        Console.WriteLine();
        Console.WriteLine($"Maaş : {kisi.Maas} Yaş {kisi.Yas}");

        User kullanici = new User()
        {
            Name = "Alp" , Email = "alp@arslan.com" , Password = "123"
        };
        kullanici.KayitTarihi = DateTime.Now;

        Console.WriteLine();
        Console.WriteLine("Kullanıcı Bilgileri :");
        Console.WriteLine($"Adı : {kullanici.Name} Email :  {kullanici.Email}");

        User user = new() // bu userin bilgilerini Email ve Password bilgilerini ekrana girdir. user içersinde ki
                           // metodu kullanarak giriş başarılı veya başarısız mesajı veridir.
        {
            Name = "Alp" , Email = "alp@arslan.com" , Password = "123"
        };

        Console.WriteLine("Email Adersinizi Giriniz :");

        var email = Console.ReadLine();
       
        Console.WriteLine("Şifrenizi Giriniz :");

        var sifre = Console.ReadLine();
        var sonuc = user.KullaniciGiris(email,sifre); // ekrandan aldığımız değerleri kullanıcıGiris metotuna 
        // gönderiyoruz ve o metottdan true veya false değerini sonuç değikenine aktarıyoruz.
        if (sonuc == true)
        {
            Console.WriteLine("Giriş Başarılı");
        }
        else Console.WriteLine("Giriş Başarısız");
        

    }
}
class Skorlar
{
    private int skor;
    public int Skor
    {
        get { return skor; }
        set { skor = value; }
    }
}

