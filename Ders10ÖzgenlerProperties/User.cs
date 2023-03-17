

namespace Ders10ÖzgenlerProperties
{
    internal class User
    {
        public string Name { get; set; } // property lerin kapalı kullanılabilen hali
        public string Email { get; set; } 
        public string Password { get; set; } // uygulama geliştirirken bu property leri kullanırız

        public string Telefon { get; set; } // prop yazıp tab a basark kısayolla oluşturabiliriz.

        public DateTime KayitTarihi { get; set; }

        public bool KullaniciGiris(string mail, string sifre)
        {
            string dbDekiEmail = "alp@arslan.net";
            string dbDekiSifre = "123";
            if (mail == dbDekiEmail && sifre == dbDekiSifre)
            {
                return true;
            }
            return false;
        }

    }
}
