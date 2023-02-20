// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Koşul Yapıları");

int Sayi = 10; // (-) eksi değer aldığı zaman da negatif sayı ile karşılaşırız.

Console.WriteLine("Lütfen Bir Sayı Giriniz");

//Sayi = Convert.ToInt32(Console.ReadLine()); // ekranda veri alabilmek için readline metodu kullanılır. realine metodu ekrandan 
//verileri string olark alır , sayısal işlem yapacaksak bunu dönüştürmemiz gerekir!

if (Sayi > 0) // eğer sayi sıfırdan büyükse 
{
    Console.WriteLine("Sayi pozitif");
}
else if (Sayi < 0)
{
    Console.WriteLine("Sayi Negatif");
}
else
{
    Console.WriteLine("Sayi 0");
}


Console.WriteLine();

Console.WriteLine("Kullanıcı Adını Giriniz :");


string kullaniciAdi = Console.ReadLine();


Console.WriteLine("Şifrenizi Giriniz :");


string Şifre = Console.ReadLine();

if (kullaniciAdi == "admin" && Şifre == "123")
{
    Console.WriteLine("Giriş Başarılı! \n Hoşgeldin : " + kullaniciAdi);
}
else
{
    Console.WriteLine("Giriş Başarısız!");
}

int saat = DateTime.Now.Hour; // DateTime ile tarih ve saat bilgilerine ulaşırız

if (saat > 19)
    Console.WriteLine("İyi Akşamlar");
else
    Console.WriteLine(" Saat :" + saat + "İyi Günler");

Console.WriteLine();

Console.WriteLine("Ternary operatörü");

Console.WriteLine((saat > 19) ? "saat : " + saat + "İyi Akşamlar " : "saat : " + saat + "İyi Günler");

Console.WriteLine();

Console.WriteLine("Swich case  Kullanımı");


int ay = DateTime.Now.Hour; // bulunduğumuz ay değernine ulaşırız

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Mevsim Kış");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("Mevsim İlk Bahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Mevsim Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Mevsim SonBahar");
        break;

    default:
        Console.WriteLine("Hiç bir şart uymadıysa default çalışır");
        break;
}