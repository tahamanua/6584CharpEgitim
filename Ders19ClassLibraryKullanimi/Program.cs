using Entities;

namespace Ders19ClassLibraryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassLibrary Kullanimi");
            // Bu proje de Entities ClassLibrary kütüphanesini kullanabilmek için Depedencies e sağ tıklayıp add project
            // refenceres diyerek açılan pencereden Entities projesini seçip OK diyerek pencereyi kapattık. Artık Entities
            // içersinde ki class lara erişim belirteçleri izin veriyorsa erişip kullanabiliriz.

            Kategori kategori = new()
            {
                Id = 1, Name = "Bilgisayar", 
            };
            var urunler = new List<Urun>(); 
            urunler.Add(new Urun() { Name = "Klavye" , Image = "urun1.jpg" , Price = 199});
            urunler.Add(new Urun() { Name = "Mouse", Image = "urun2.jpg", Price = 159 });
            urunler.Add(new Urun() { Name = "Monitör", Image = "urun3.jpg", Price = 3339 });
            Console.WriteLine("Kategori : " + kategori.Name);
            Console.WriteLine();
            Console.WriteLine("Ürünler : ");
            foreach (var item in urunler)
            {
                Console.WriteLine($"Ürün Adı : {item.Name} - Fiyatı : {item.Price}");

            }


        }

    }
}