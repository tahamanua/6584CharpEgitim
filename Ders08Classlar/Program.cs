// See https://aka.ms/new-console-template for more information


using Ders08Classlar;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - class");
            Ev İlkEv = new Ev(); // soyut bir yapı olan ev sınıfından , somut bir nesne olan ilkev i oluşturduk
            İlkEv.sokakAdi = "Okul sk"; 
            İlkEv.kapiNo = 10;
            Console.WriteLine("İlk ev sokak adı : " + İlkEv.sokakAdi);
            Console.WriteLine("İlk ev kapı numarası: " + İlkEv.kapiNo);


            Ev yazlikEv= new Ev();
            yazlikEv.sokakAdi = "Deniz Sk.";
            yazlikEv.kapiNo = 18;
            Console.WriteLine("yazlik Ev sokak adı : " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlik Ev kapı numarası: " + yazlikEv.kapiNo);

            Ev koyEvi = new()
            {
                sokakAdi = "Emek sk", // bu kullanımda ; yerine öğeler arasında (,) koymamız gerekli.
                kapiNo = 34
            };
            Console.WriteLine("Köy Evi sokak adı : " + koyEvi.sokakAdi);
            Console.WriteLine("Köy Evi kapı numarası: " + koyEvi.kapiNo);

            Console.WriteLine();

            kullanici kullanici = new()
            {
                Adi = "Deniz",
                SoyAdi = "Çoban",
                Email = "denizcoban@gmail.com",
                Id = 1,
                KullaniciAdi = "deniz",
                Sifre = "1234",
             };

            kullanici Taha = new()
            {
                Adi = "Taha",
                SoyAdi = "Atmaca",
                Email = "tahamanua49@gmail.com",
                Id = 15,
                KullaniciAdi = "Tahamanua",
                Sifre = "046749"
            };

            Console.WriteLine("Kendi Kullanıcımız \n Adı : {0} SoyAdı : {1}", Taha.Adi, Taha.SoyAdi);

            Araba araba = new()
            {
                Id = 1,
               Markası = "Dacia",
               KasaTipi = "Sedan",
               Model = "2016",
               VitesTipi = "Manuel",
               YakıtTipi = "Dizel",
               Renk = "Siyah"
            };

            Console.WriteLine("Araç Bilgisi : ");
            Console.WriteLine($"Marka :{araba.Markası} \n  Model : {araba.Model} \n Renk : {araba.Renk}");


            Console.WriteLine();


            Araba araba2 = new()
            {
                Id = 22,
                Markası = "Ford",
                Model = " 1967 Mustang ",
                Renk = "Siyah"

            };


            Console.WriteLine(" 2 Araç Bilgisi : ");
            Console.WriteLine($"Marka :{araba2.Markası} \n  Model : {araba2.Model} \n Renk : {araba2.Renk}");

            /*
            Console.WriteLine("Kullanıcı Adınız :");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine("Hoşgeldin : " + kullanici.Adi + "" + kullanici.SoyAdi);
            }
            else Console.WriteLine("Giriş Başarısız!");
            */
            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Elektronik"

            };
            Kategori kategori2 = new()
            {
                Id = 2,
                KategoriAdi = "Bilgisayar"

            };
            Kategori kategori3 = new()
            {
                Id = 3,
                KategoriAdi = "Telefon"

            };

            Console.WriteLine("Kategori : " + kategori.KategoriAdi);
            Console.WriteLine("Kategori2 : " + kategori2.KategoriAdi);
            Console.WriteLine("Kategori3 : " + kategori3.KategoriAdi);

            SiniftaMetotKullanimi metotKUllanımı = new();
             var sonuc = metotKUllanımı.LoginKontrol("admin" , "1234");
            if (sonuc == true)
            {
                Console.WriteLine("Giriş başarılı!");
            }
            else Console.WriteLine("<giriş Başarısız!");

            Urun urun = new()
            {
                Adi = "Klavye", Fiyati = 249, UrunAciklamasi = "RGB  Işıklı " , Id = 1 , Markasi = "Logitech"


            };
            Urun mouse = new()
            {
                Adi = "Mouse", Fiyati = 199, UrunAciklamasi = "Kablolu", Markasi = "Rampage"


            };

            Console.WriteLine("Ürün Bilgileri : ");
            Console.WriteLine($"Ürün Adı : {urun.Adi}");
            Console.WriteLine($"Ürün fiyatı : {urun.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {urun.UrunAciklamasi}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {urun.Markasi}");

            Console.WriteLine();


            Console.WriteLine("Ürün Bilgileri : ");
            Console.WriteLine($"Ürün Adı : {mouse.Adi}");
            Console.WriteLine($"Ürün fiyatı : {mouse.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {mouse.UrunAciklamasi}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {mouse.Markasi}");



        } // main metot bitişi 

        class Ev // sınıf tanımlama 
        {
            internal string sokakAdi;
            internal int kapiNo;
        }

        
    }
    class kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string SoyAdi;

        public string? KullaniciAdiniz { get; internal set; }
    }
    class Araba
    {
        internal int Id;
        internal string Markası;
        internal string Model;
        internal string KasaTipi;
        internal string YakıtTipi;
        internal string VitesTipi;
        internal string Renk;

    }
}

