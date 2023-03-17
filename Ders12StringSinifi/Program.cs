namespace Ders12StringSinifi
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("String Sınıfı!");

            string metin = "değişken";

            char karakter = 'K';
            Ornek1();
            StringMetotlari();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara Başkenttir";
            string birSayi = "123456789";
            System.String birTarih = "04.05.2023";
            string s = "C# Eğitimi";
            Console.WriteLine("s yi for ile yazdırma");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i +"]" + s[i]);    
            }
            Console.WriteLine("s yi forech ile yazdırma");
            foreach (var item in s) // s değişkeni içindeki her bir karakter için dön 
            {
                Console.WriteLine(item); // her karakteri bir satırda yazıdır
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin Bir Çok Metodu Vardır.";

            Console.WriteLine("metin in karakter sayısı(metin.Length) : " + metin.Length);
            var klon = metin.Clone();
            Console.WriteLine("metnin klonu : " + klon);
            metin = "My Name İs Tahamanua";
            Console.WriteLine(metin + "metin.EndsWith(\"a\") metin a ile mi bitiyor : " + metin.EndsWith("a"));
            Console.WriteLine(metin + "metin.EndsWith(\"r\") metin r ile mi bitiyor : " + metin.EndsWith("r"));
            Console.WriteLine(metin + "metin.StartsWith(\"r\") metin r ile mi başlıyor : " + metin.StartsWith("r"));
            Console.WriteLine(metin + "metin.StartsWith(\"m\") metin m ile mi başlıyor : " + metin.StartsWith("m"));
            Console.WriteLine(metin + "metin.StartsWith(\"M\") metin M ile mi başlıyor : " + metin.StartsWith("M"));
            Console.WriteLine(metin + "metin.IndexOf(\"name\") metin içinde ki name in index değeri : " + metin.IndexOf("name"));
            Console.WriteLine(metin + "metin.IndexOf(\"Name\") metin içinde ki Name in index değeri : " + metin.IndexOf("Name"));
            Console.WriteLine(metin + "metin.IndexOf(\"a\") metin içinde ki a in index değeri : " + metin.LastIndexOf("a"));
            Console.WriteLine(metin + "metin.Insert(metin.Insert(0,\"Merhaba : \")) metin e Merhaba ekleme : " + metin.Insert(0,"Merhaba : "));
            // Insert de metnin değeri değişiyor sadece o anlık ekliyor.

            Console.WriteLine(metin);
            Console.WriteLine(metin.Substring(6, 10)); // substring metinden parça alır, kaçıncı karakterden itibaren kaç karakter alacağımızı belirtiyoruz
            Console.WriteLine(metin.ToLower());// metini küçük harfe çevirir.
            Console.WriteLine(metin.ToUpper());
            Console.WriteLine(metin.ToLower().Replace(" ","-"));// metni küçük harfe çeviri ve içindeki boşlukları - ile değiştirir.
            Console.WriteLine(metin.ToUpper().Replace(" ", "-"));
            Console.WriteLine(metin.Remove(0,2));// metinde seçili alanı silmek için
        }
    }
}

