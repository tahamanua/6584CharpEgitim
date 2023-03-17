

namespace Ders08Classlar
{
    public class SiniftaMetotKullanimi // internal = erişim belirteci
    {
        string kurucuMetot; // bsşında erişim belirteci yazmazsak sadece bulunduğu süslü parantez içinden erişebilirz.
        public SiniftaMetotKullanimi() // ctor yazıp klavyeden iki kere tab a basarsak bu kodu oluşturabilirz
        {
            kurucuMetot = "Sınıflarda kurucu metot (constructor) sistemi vardır ve sınıftan new ile bir nesne oluşturduğumuzda ilk önce bu metot çalışır! ";
            Console.WriteLine(kurucuMetot);
        }
       
        public bool LoginKontrol(string kullanici, string sifre)
        {
            if (kullanici == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }
        internal bool MailGonder(string email)
        {
            if (email != "")
            {
                return true;
            }
            return false;
        }

    }
}
