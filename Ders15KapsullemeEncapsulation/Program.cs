namespace Ders15KapsullemeEncapsulation
{
    internal class Program
    {
        // Metot kullanarak kapsülleme 

        public class Bolum
        {
            private string BolumAdi;
            public string GetBolumAdi() // Accesor - Getter
            {
                return BolumAdi;
            }
            public void SetBolumAdi(string a)
            {
                if (a == "Yazılım Mühendisliği") // eğer metoda gönderilen değer geçersizse 
                {
                    Console.WriteLine("Okulumuzda bu bölüm bulunmamaktadır.");
                }
                else BolumAdi = a; // geçerliyse private değikeni değeri ata
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsulleme - Encapsulation!");
            //Console.WriteLine("C# ta özegen yapısı kullanılarak verileri kapsülleyebilir istemediğimiz veriye engel olabilir.");
            Bolum bolum = new();
            Console.WriteLine("Tercih ettiğiniz bölümü giriniz!");
            var secilenBolum = Console.ReadLine();
            bolum.SetBolumAdi(secilenBolum);
            Console.WriteLine("Seçtiğiniz Bölüm : " + bolum.GetBolumAdi());
        }
        //  Özgen-Property Kullanarak Kapsülleme 
        class Fakulte
        {
            private string bolum;
            public string Bolum
            {
                get { return bolum; }
                set
                {
                    if (value == "Yazılım Mühendisliği")
                    {
                        Console.WriteLine("Okulumuzda Bu Bölüm Bulunmamaktadır");
                    }
                   else bolum = value;

                }
            }
        }
    }
}